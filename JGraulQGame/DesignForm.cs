/* JGraulQGame.cs
 * Assignment 3
 * Revision History
 *      Jack Graul, 2023.10.30: Created
 *      Jack Graul, 2023.10.30: Designed UI
 *      Jack Graul, 2023.10.30: Added Code
 *      Jack Graul, 2023.10.30: Added Comments
 *      Jack Graul, 2023.11.05: Updated Code
 *      Jack Graul, 2023.11.05: Updated Comments
 *      Jack Graul, 2023.11.27: Added Loading Levels
 *      Jack Graul, 2023.11.27: Added Play Functionality
 *      Jack Graul, 2023.11.27: Updated Comments
 *      Jack Graul, 2023.12.01: Updated Code and Comments
 */

using JGraulQGame.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JGraulQGame
{
    public partial class DesignForm : Form
    {
        private int imageIndex = 0;
        private string currentFile;
        private SoundPlayer _error = new SoundPlayer(Resources.windowsXpError);
        private SoundPlayer _save = new SoundPlayer(Resources.mlg_airhorn);
        private SoundPlayer _load = new SoundPlayer(Resources.windowsXpStartup);
        private SoundPlayer _close = new SoundPlayer(Resources.windowsXpShutdown);

        public DesignForm()
        {
            InitializeComponent();
        }

        // This button click generates the grid for the game
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            int rows, columns;

            // Tries to parse an int from the text fields for rows and columns
            if (int.TryParse(txtRows.Text, out rows) && int.TryParse(txtColumns.Text, out columns))
            {
                // Checks if the row or column fields are less than or equal to 0 and displays an error if so
                if (rows <= 0 || columns <= 0)
                {
                    _error.Play();
                    MessageBox.Show("Please provide valid data for rows and columns. Value must be an integer greater than 0");
                }
                else if (rows > 8 || columns > 8)
                {
                    _error.Play();
                    MessageBox.Show("Max grid size is 8x8");
                }
                else
                {
                    // Checking if there are grid tiles generated already
                    // If there are, a dialog prompt will appear
                    if (panelGrid.Controls.Count > 0)
                    {
                        DialogResult result = MessageBox.Show("Do you want to create a new level? If you do, the current level will be lost",
                            "Create New Level", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            panelGrid.Controls.Clear();
                            GenerateGrid(rows, columns);
                        }
                        else
                        {
                            return;
                        }
                    }
                    else
                    {
                        panelGrid.Controls.Clear();
                        GenerateGrid(rows, columns);
                    }
                }
            }
            // If the try parse fails then the input type is incorrect and an error is shown
            else
            {
                _error.Play();
                MessageBox.Show("Input was not in a correct format. Please use an integer to define the rows and columns");
            }
        }

        // Method to generate the grid
        private void GenerateGrid(int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    GridTile gridTile = new GridTile();
                    gridTile.Width = 50;
                    gridTile.Height = 50;
                    gridTile.Left = j * 50;
                    gridTile.Top = i * 50;
                    gridTile.BorderStyle = BorderStyle.Fixed3D;
                    gridTile.Image = JGraulQGame.Properties.Resources.none;
                    gridTile.Row = i;
                    gridTile.Column = j;

                    panelGrid.Controls.Add(gridTile);
                    gridTile.Click += GridTile_Click;
                }
            }
        }

        // Loads save file using 2D array
        public void LoadGrid(int[,] grid)
        {
			for (int i = 0; i < grid.GetLength(0); i++)
			{
				for (int j = 0; j < grid.GetLength(1); j++)
				{
					GridTile gridTile = new GridTile();
					gridTile.Width = 50;
					gridTile.Height = 50;
					gridTile.Left = j * 50;
					gridTile.Top = i * 50;
					gridTile.BorderStyle = BorderStyle.Fixed3D;
                    gridTile.Row= i;
                    gridTile.Column = j;
                    gridTile.ImageIndex = grid[i, j];

					panelGrid.Controls.Add(gridTile);
					gridTile.Click += GridTile_Click;
				}
			}
		}

        // Method to handle the different toolbox button clicks
        private void HandleToolBoxClick(object sender, EventArgs e)
        {
            Button toolBox = sender as Button;

            if (toolBox != null)
            {
                imageIndex = toolBox.ImageIndex;
            }
        }

        // Method for changing the image on the grid tiles
        public void GridTile_Click(object sender, EventArgs e)
        {
            // Check if a toolbox button was selected
            if (imageIndex != -1)
            {
                // Set the imageIndex of the clicked GridTile
                GridTile clickedTile = sender as GridTile;
                if (clickedTile != null)
                {
                    clickedTile.ImageIndex = imageIndex;
                }
            }
            // If no toolbox button was selected, show error
            else
            {
                _error.Play();
                MessageBox.Show("Please select a toolbox item before clicking on the grid.");
            }
        }

        // Save dialog
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelGrid.Controls.Count <= 0)
            {
                _error.Play();
                MessageBox.Show("Error. There is no level to save");
            }
            else
            {
                // Adding rows and cols of the grid
                string gridSave = $"{txtRows.Text}\n{txtColumns.Text}\n";
				// Iterates through each gridTile in the panel and sets it's properties to a string
				foreach (GridTile gridTile in panelGrid.Controls)
                {
                    gridSave += $"{gridTile.Row},{gridTile.Column},{gridTile.ImageIndex}\n";
                }

                if (currentFile != null)
                {
                    string fileName = currentFile;
                    StreamWriter writer = new StreamWriter(fileName);

                    writer.WriteLine(gridSave.Trim());
                    writer.Close();

                    SaveMessageBox();
                }
                else
                {
                    DialogResult dialogResult = saveFileDialog1.ShowDialog();
                    switch (dialogResult)
                    {
                        case DialogResult.OK:
                            string fileName = saveFileDialog1.FileName;
                            StreamWriter writer = new StreamWriter(fileName);

                            writer.WriteLine(gridSave.Trim());
                            writer.Close();

                            SaveMessageBox();
                            break;
                        default: break;
                    }
                }
            }
        }

        // Method to display the number of walls, boxes, and doors upon saving a file
        private void SaveMessageBox()
        {
            int walls = 0;
            int boxes = 0;
            int doors = 0;

            foreach (GridTile gridTile in panelGrid.Controls)
            {
                if (gridTile.ImageIndex == 1)
                {
                    walls++;
                }
                else if (gridTile.ImageIndex == 2 ||  gridTile.ImageIndex == 4)
                {
                    boxes++;
                }
                else if (gridTile.ImageIndex == 3 || gridTile.ImageIndex == 5)
                {
                    doors++;
                }
            }

            _save.Play();
            DialogResult ok = MessageBox.Show($"File saved successfully\nWalls: {walls}\nBoxes: {boxes}\nDoors: {doors}", "", MessageBoxButtons.OK);

            if (ok == DialogResult.OK)
            {
                _save.Stop();
            }
            
        }

        // Loading a save file
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelGrid.Controls.Count > 0)
            {
				DialogResult result = MessageBox.Show("Do you want to load a new level? If you do, the current level will be lost",
			"Create New Level", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    LoadFile();
                }
                else
                {
                    return;
                }
			}
            else
            {
                LoadFile();
            }
		}

        private void LoadFile()
        {
			DialogResult dialogResult = openFileDialog1.ShowDialog();
			switch (dialogResult)
			{
				case DialogResult.OK:
					string fileName = openFileDialog1.FileName;
					currentFile = fileName;
					StreamReader reader = new StreamReader(fileName);

					// Get the rows and cols from the first 2 lines of the save file
					int rows = int.Parse(reader.ReadLine());
					int cols = int.Parse(reader.ReadLine());

					// Generate 2D array using rows and cols
					int[,] grid = new int[rows, cols];

					int lineNumber = 0;

					while (reader.Peek() != -1)
					{
						lineNumber++;

						// Reader gets the line and it is split by ',' in order to get each tile's row, col, and imageIndex
						string line = reader.ReadLine();
						string[] tile = line.Split(',');

						if (tile.Length >= 3 && int.TryParse(tile[0], out int row) && int.TryParse(tile[1], out int col) && int.TryParse(tile[2], out int imageIndex))
						{
							if (row >= 0 && row < rows && col >= 0 && col < cols)
							{
								// Each gridTile is assigned the appropriate imageIndex
								grid[row, col] = imageIndex;
							}
							else
							{
                                _error.Play();
								MessageBox.Show($"Error at line {lineNumber}: Row or column index out of bounds - {line}");
							}
						}
						else
						{
                            _error.Play();
							MessageBox.Show($"Error at line {lineNumber}: Unable to parse values - {line}");
						}
					}

                    // Set fields so that they are read when saving in the case of loading a level to edit and save it
                    txtRows.Text = rows.ToString();
                    txtColumns.Text = cols.ToString();

					panelGrid.Controls.Clear();
					LoadGrid(grid);

					reader.Close();

                    _load.Play();
					break;
				default:
					break;
			}
		}

		// Close dialog
		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (panelGrid.Controls.Count == 0)
			{
                _close.Play();
                this.Close();
			}
			else
			{
				DialogResult result = MessageBox.Show("Do you want to close the current level? If you do, unsaved changes will be lost",
				"Close Level", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

				if (result == DialogResult.Yes)
				{
                    _close.Play();
					this.Close();
				}
				else
				{
					return;
				}
			}
		}
	}
}
