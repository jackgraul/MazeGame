using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JGraulQGame
{
    public class GridTile : PictureBox
    {
        // Properties
        private int imageIndex;
        private int row;
        private int column;

        public int ImageIndex
        {
            get 
            { 
                return imageIndex; 
            }
            set
            {
                imageIndex = value;
                UpdateImage();
            }
        }

        public int Row
        {
            get
            {
                return row;
            }
            set
            {
                row = value;
            }
        }

        public int Column
        {
            get
            {
                return column;
            }
            set
            {
                column = value;
            }
        }

        // Constructor
        public GridTile()
        {
            ImageIndex = 0;
            Row = 0;
            Column = 0;

            this.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        // Method with a switch statement to update the gridTile's image based of ImageIndex
        private void UpdateImage()
        {
            switch (ImageIndex)
            {
                case 0:
                    Image = JGraulQGame.Properties.Resources.none;
                    break;
                case 1:
                    Image = JGraulQGame.Properties.Resources.wall;
                    break;
                case 2:
                    Image = JGraulQGame.Properties.Resources.greenBox;
                    break;
                case 3:
                    Image = JGraulQGame.Properties.Resources.greenDoor;
                    break;
                case 4:
                    Image = JGraulQGame.Properties.Resources.redBox;
                    break;
                case 5:
                    Image = JGraulQGame.Properties.Resources.redDoor;
                    break;
                default:
                    Image = null;
                    break;
            }
        }
    }
}
