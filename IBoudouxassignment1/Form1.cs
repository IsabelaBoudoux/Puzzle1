using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBoudouxassignment1
{
    public partial class QPuzzel : Form
    {

        private const int LEFT = 220;
        private const int WIDTH = 50;
        private const int HEIGHT = 50;
        private const int TOP = 100;
        private const int NONE = 0;
        private const int WALL = 1;
        private const int BBLUE = 2;
        private const int BGREEN = 3;
        private const int BRED = 4;
        private const int BYELLOW = 5;
        private const int DBLUE = 6;
        private const int DGREEN = 7;
        private const int DRED = 8;
        private const int DYELLOW = 9;
        int numberOfRows;
        int numberOfCols;
        PictureBox[,] p;
        ImageType imageType;

        public QPuzzel()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Enum method to name the picture
        /// </summary>
        enum ImageType
        {
            None,
            boxgreen,
            boxyellow,
            boxblue,
            boxred,
            doorgreen,
            dooryellow,
            doorblue,
            doorred,
            wall
        }
        /// <summary>
        /// Method to generate the grid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenarate_Click(object sender, EventArgs e)
        {
            try
            {
                numberOfCols = int.Parse(txtCol.Text);
                numberOfRows = int.Parse(txtRow.Text);

                if (numberOfCols<=0|| numberOfRows<=0)
                {
                    MessageBox.Show("Please choose a number greather then zero");
                }
             
            }
            catch (Exception)
            {
                MessageBox.Show("Please choose a number ");
            }
             
             p = new PictureBox[numberOfCols, numberOfRows];

            int x = LEFT;
            int y = TOP;

            for (int i = 0; i < numberOfRows; i++)
            {
                y = TOP;

                for (int j = 0; j < numberOfCols; j++)
                {
                    p[i, j] = new PictureBox();
                    p[i, j].BorderStyle = BorderStyle.Fixed3D;
                    p[i, j].Left = x;
                    p[i, j].Top = y;
                    p[i, j].Height = HEIGHT;
                    p[i, j].SizeMode = PictureBoxSizeMode.Zoom;
                    p[i, j].Width = WIDTH;
                    p[i, j].Text = j.ToString();
                    p[i, j].Click += P_Click;

                    this.Controls.Add(p[i,j]);
                    y += HEIGHT;
                }
                x += WIDTH;
            }
        }
        /// <summary>
        /// This method click will put an image and a tag in each pictureBox 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void P_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;

            switch (imageType)
            {
                case ImageType.None:
                    p.Image = null;
                    p.Tag = NONE;
                    break;
                case ImageType.boxgreen:
                    p.Image = IBoudouxassignment1.Properties.Resources.boxGreen;
                    p.Tag = BGREEN;
                    break;
                case ImageType.boxyellow:
                    p.Image = IBoudouxassignment1.Properties.Resources.boxYellow;
                    p.Tag = BYELLOW;
                    break;
                case ImageType.boxblue:
                    p.Image = IBoudouxassignment1.Properties.Resources.boxBlue;
                    p.Tag = BBLUE;
                    break;
                case ImageType.boxred:
                    p.Image = IBoudouxassignment1.Properties.Resources.boxRed;
                    p.Tag = BRED;
                    break;
                case ImageType.doorgreen:
                    p.Image = IBoudouxassignment1.Properties.Resources.doorGreen;
                    p.Tag = DGREEN;
                    break;
                case ImageType.dooryellow:
                    p.Image = IBoudouxassignment1.Properties.Resources.doorYellow;
                    p.Tag = DYELLOW;
                    break;
                case ImageType.doorblue:
                    p.Image = IBoudouxassignment1.Properties.Resources.doorBlue;
                    p.Tag = DBLUE;
                    break;
                case ImageType.doorred:
                    p.Image = IBoudouxassignment1.Properties.Resources.doorRed;
                    p.Tag = DRED;
                    break;
                case ImageType.wall:
                    p.Image = IBoudouxassignment1.Properties.Resources.wall;
                    p.Tag = WALL;
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// This button select the picture wall 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region MyRegionbuttons
        private void btnWall_Click(object sender, EventArgs e)
        {
            imageType = ImageType.wall;
        }
        /// <summary>
        /// This button select the blue box picture  
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBlueBox_Click(object sender, EventArgs e)
        {
            imageType = ImageType.boxblue;
        }
        /// <summary>
        /// This button select the Green box picture 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGreenBox_Click(object sender, EventArgs e)
        {
            imageType = ImageType.boxgreen;
        }
        /// <summary>
        /// This button select the Red box picture 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRedBox_Click(object sender, EventArgs e)
        {
            imageType = ImageType.boxred;
        }
        /// <summary>
        /// This button select the Yellow box picture 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYellowBox_Click(object sender, EventArgs e)
        {
            imageType = ImageType.boxyellow;
        }
        /// <summary>
        /// This button select the Blue door picture 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBlueDoor_Click(object sender, EventArgs e)
        {
            imageType = ImageType.doorblue;
        }
        /// <summary>
        /// This button select the Green door picture 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGreenDoor_Click(object sender, EventArgs e)
        {
            imageType = ImageType.doorgreen;
        }
        /// <summary>
        /// This button select the Red door picture 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRedDoor_Click(object sender, EventArgs e)
        {
            imageType = ImageType.doorred;
        }
        /// <summary>
        /// This button select the None picture 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNone_Click(object sender, EventArgs e)
        {
            imageType = ImageType.None;
        }
        /// <summary>
        /// This button select the Yellow door picture 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnYellowDoor_Click(object sender, EventArgs e)
        {
            imageType = ImageType.dooryellow;
        } 
        #endregion
        /// <summary>
        /// Method to save the file 
        /// </summary>
        /// <param name="fileName"></param>
        private void SaveFile(string fileName)
        {
            StreamWriter writer;
            writer = new StreamWriter(fileName);
            try
            {
                numberOfCols = int.Parse(txtCol.Text);
                numberOfRows = int.Parse(txtRow.Text);

                if (numberOfCols < 0 || numberOfRows < 0)
                {
                    MessageBox.Show("Please choose a number greather then zero");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Please choose a number ");
            }

            writer.WriteLine(numberOfRows);
            writer.WriteLine(numberOfCols);
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfCols; j++)
                {
                    if (p[i, j].Image is null)
                    {
                        p[i, j].Tag = 0;
                        writer.WriteLine(p[i,j].Tag);
                    }
                    else
                    {
                        writer.WriteLine(p[i, j].Tag);
                    }               
                }
            }
            writer.Close();
        }
        /// <summary>
        ///  The save strip Menu option will sabe the file with the design created
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            dlgSave.DefaultExt = ".txt";
            DialogResult result = dlgSave.ShowDialog();
            switch (result)
            {
                case DialogResult.None:
                    break;
                case DialogResult.OK:

                    try
                    {
                        string filename = dlgSave.FileName;
                        SaveFile(filename);
                        MessageBox.Show("File Saved");
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("ERROR- File not saved");
                    }
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Abort:
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.Yes:
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }
        }
    }
}
