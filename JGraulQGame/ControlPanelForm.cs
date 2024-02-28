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
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JGraulQGame
{
    public partial class ControlPanelForm : Form
    {
        private SoundPlayer _play = new SoundPlayer(Resources.among_us_roundstart);
        private SoundPlayer _design = new SoundPlayer(Resources.law_and_order_dun_dun);

		public ControlPanelForm()
        {
            InitializeComponent();
        }

        // Plays a level
        private void btnPlay_Click(object sender, EventArgs e)
        {
            _play.Play();
            PlayForm playForm = new PlayForm();
            playForm.ShowDialog();
        }

        // Opens DesignForm
        private void btnDesign_Click(object sender, EventArgs e)
        {
            _design.Play();
            DesignForm designForm = new DesignForm();
            designForm.ShowDialog();
        }

        // Closes application
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
