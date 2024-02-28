/* JGraulQGame.cs
 * Assignment 3
 * Revision History
 *      Jack Graul, 2023.10.30: Created
 *      Jack Graul, 2023.10.30: Designed UI
 *      Jack Graul, 2023.10.30: Added code
 *      Jack Graul, 2023.10.30: Added comments
 *      Jack Graul, 2023.11.05: Updated code
 *      Jack Graul, 2023.11.05: Updated comments
 *      Jack Graul, 2023.11.27: Added loading levels
 *      Jack Graul, 2023.11.27: Added play functionality
 *      Jack Graul, 2023.11.27: Updated comments
 *      Jack Graul, 2023.12.01: Updated code and comments
 *      Jack Graul, 2024.02.28: Fixed bug allowing red boxes moving into green doors and vice versa
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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JGraulQGame
{
	public partial class PlayForm : Form
	{
		bool isGreenBoxSelected = false;
        bool isRedBoxSelected = false;
        int[,] grid;
		int selectedBoxRow;
		int selectedBoxColumn;
		int moves = 0;
		int boxes;
		private string currentFile;
		private SoundPlayer _victory = new SoundPlayer(Resources.nflTheme);
		private SoundPlayer _success = new SoundPlayer(Resources.tacoBell);
		private SoundPlayer _error = new SoundPlayer(Resources.windowsXpError);
		private SoundPlayer _load = new SoundPlayer(Resources.windowsXpStartup);
		private SoundPlayer _close = new SoundPlayer(Resources.windowsXpShutdown);

		public PlayForm()
		{
			InitializeComponent();
			txtMoves.Text = moves.ToString();
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
					gridTile.Row = i;
					gridTile.Column = j;
					gridTile.ImageIndex = grid[i, j];

					panelGrid.Controls.Add(gridTile);
					gridTile.Click += GridTile_Click;
				}
			}
		}

		// Loading a level using LoadFile()
		private void loadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (panelGrid.Controls.Count > 0)
			{
				DialogResult result = MessageBox.Show("Do you want to load a new level? If you do, the current level will be lost",
			"Load New Level", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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

		// Load Level
		private void LoadFile()
		{
			moves = 0;

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
					grid = new int[rows, cols];

					int lineNumber = 0;

					while (reader.Peek() != -1)
					{
						lineNumber++;

						// Reader gets the line and it is split by ',' in order to get each tile's row, col, and imageIndex
						string line = reader.ReadLine();
						string[] tile = line.Split(',');

						// Parse row, col, and imageIndex from the array tile
						if (tile.Length >= 3 && int.TryParse(tile[0], out int row) && int.TryParse(tile[1], out int col) && int.TryParse(tile[2], out int imageIndex))
						{
							if (row >= 0 && row < rows && col >= 0 && col < cols)
							{
								// Each gridTile is assigned the appropriate imageIndex at the correct position
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

					// Clears panel in case there is already a grid and loads the grid
					panelGrid.Controls.Clear();
					LoadGrid(grid);

					// Reset to 0 so when loading a new game it doesn't add to the previous game's boxes
					boxes = 0;

					// Gets the number of boxes in the level
					foreach (GridTile tile in panelGrid.Controls)
					{
						if (tile.ImageIndex == 2 || tile.ImageIndex == 4)
						{
							boxes++;
						}
					}
					txtBoxes.Text = boxes.ToString();
					txtMoves.Text = moves.ToString();

					reader.Close();

					_load.Play();
					break;
				default:
					break;
			}
		}

		// Close play form
		private void closeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (panelGrid.Controls.Count == 0)
			{
				_close.Play();
				this.Close();
			}
			else
			{
				DialogResult result = MessageBox.Show("Do you want to close the current level? If you do, your progress will be lost",
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

		// Checks if a box was clicked
		public void GridTile_Click(object sender, EventArgs e)
		{
			GridTile clickedTile = sender as GridTile;
			if (clickedTile != null)
			{
				if (clickedTile.ImageIndex == 2)
				{
					isGreenBoxSelected = true;
					selectedBoxRow = clickedTile.Row;
					selectedBoxColumn = clickedTile.Column;
				}
				else if (clickedTile.ImageIndex == 4)
				{
                    isRedBoxSelected = true;
                    selectedBoxRow = clickedTile.Row;
                    selectedBoxColumn = clickedTile.Column;
                }
				else
				{
					isGreenBoxSelected = false;
                    isRedBoxSelected = false;
                }
            }
		}

		// Handler for the movement buttons
		private void HandleMovementButtonClick(object sender, EventArgs e)
		{
			Button clickedButton = sender as Button;

			int newRow = selectedBoxRow;
			int newCol = selectedBoxColumn;
			string direction = "";

			if (isGreenBoxSelected || isRedBoxSelected)
			{
				switch (clickedButton.Name)
				{
					case "btnUp":
						newRow--;
						direction = "up";
						break;
					case "btnDown":
						newRow++;
						direction = "down";
						break;
					case "btnLeft":
						newCol--;
						direction = "left";
						break;
					case "btnRight":
						newCol++;
						direction = "right";
						break;
					default:
						break;
				}


				if (IsInBounds(newRow, newCol))
				{
					if (IsValidMove(newRow, newCol))
					{
						MoveBox(direction, newRow, newCol);

                        // Increment moves
                        moves++;

                        // Update textboxes
                        txtMoves.Text = moves.ToString();
						txtBoxes.Text = boxes.ToString();

						// Win check
						CheckForWin();
					}
					else
					{
						_error.Play();
						MessageBox.Show("Invalid move. Cannot move into a wall or another box");

					}
				}
				else
				{
					_error.Play();
					MessageBox.Show("Invalid move. Target position is out of bounds");
				}
			}
			else
			{
				_error.Play();
				MessageBox.Show("Box not selected");
			}
		}


        // Handles the box movement logic
        private void MoveBox(string direction, int newRow, int newCol)
        {
            while (IsInBounds(newRow, newCol) && IsValidMove(newRow, newCol))
            {
                // If target position is nothing
                if (grid[newRow, newCol] == 0)
                {
                    // Sets the previous position of the box to nothing and the new position to the selected box
                    grid[newRow, newCol] = grid[selectedBoxRow, selectedBoxColumn];
                    grid[selectedBoxRow, selectedBoxColumn] = 0;

                    // Changes position of the selected box and it's target position based on direction
                    switch (direction)
                    {
                        case "up":
                            selectedBoxRow--;
							newRow--;
                            break;
                        case "down":
                            selectedBoxRow++;
							newRow++;
                            break;
                        case "left":
                            selectedBoxColumn--;
							newCol--;
                            break;
                        case "right":
                            selectedBoxColumn++;
							newCol++;
                            break;
                    }

                    UpdateGrid();

                }
                // Green box hits green door or red box hits red door
                else if ((grid[selectedBoxRow, selectedBoxColumn] == 2 && grid[newRow, newCol] == 3) ||
                         (grid[selectedBoxRow, selectedBoxColumn] == 4 && grid[newRow, newCol] == 5))
                {
                    // Box disappears, remaining boxes decrements, and the box is no longer selected
                    grid[selectedBoxRow, selectedBoxColumn] = 0;
                    boxes--;
                    isGreenBoxSelected = false;
                    isRedBoxSelected = false;

                    // Success sound plays
                    _success.Play();

                    // Update grid with the move and exit loop
                    UpdateGrid();
                    break;
                }
                // Exit the loop when hitting another object
                else
                {
                    break;
                }
            }
        }

		// Checks if a move is within the bounds of the array
		private bool IsInBounds(int newRow, int newColumn)
		{
			if (newRow >= 0 && newRow < grid.GetLength(0) && newColumn >= 0 && newColumn < grid.GetLength(1))
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		// Checks if a box is moving to a tile with either nothing, a green door, or a red door
		private bool IsValidMove(int newRow, int newColumn)
		{
			if (isGreenBoxSelected)
			{
				if (grid[newRow, newColumn] == 0 || grid[newRow, newColumn] == 3) 
				{
					return true;
				}
				else
				{
					return false;
				}
			}
			else if (isRedBoxSelected) 
			{
                if (grid[newRow, newColumn] == 0 || grid[newRow, newColumn] == 5)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
			else
			{
				return false;
			}
        }

		// Updates the grid
		private void UpdateGrid()
		{
			// Iterate through the gridTiles in the panel and update according to the 2D array
			foreach (GridTile tile in panelGrid.Controls)
			{
				tile.ImageIndex = grid[tile.Row, tile.Column];
			}
		}

		// Checks if all the boxes have been removed, if so, victory
		private void CheckForWin()
		{
			if (boxes == 0)
			{
                _victory.Play();
				DialogResult w = MessageBox.Show("VICTORY", "Congratulations", MessageBoxButtons.OK);

				// Stops victory sound and resets the grid and textboxes
				if (w == DialogResult.OK)
				{
					_victory.Stop();
					panelGrid.Controls.Clear();
					moves = 0;
					txtMoves.Text = moves.ToString();
					txtBoxes.Text = string.Empty;
                }
            }
			else
			{
				return;
			}
		}
	}
}
