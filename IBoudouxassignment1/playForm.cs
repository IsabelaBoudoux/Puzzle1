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
    public partial class playForm : Form
    {
    /// <summary>
    /// Initialization
    /// </summary>
        public playForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Creating variables
        /// </summary>
        int numberOfRows;
        int numberOfCols;
        PictureBox[,] p;
        int actualRow;
        int actualCol;
        private const int LEFT = 50;
        private const int WIDTH = 50;
        private const int HEIGHT = 50;
        private const int TOP = 50;
        PictureBox selectPicture;
        /// <summary>
        /// Creating constants
        /// </summary>
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

        /// <summary>
        /// method enum to get the imagetype
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
        /// Genarate Method to generate the grid and get the 
        /// pictures by the line
        /// </summary>
        /// <param name="reader"></param>
        private void Generate(StreamReader reader)
        {
            p = new PictureBox[numberOfRows, numberOfCols];

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
                    int line = int.Parse(reader.ReadLine());

                    switch (line)
                    {
                        case 0:
                            p[i, j].Image = null;
                            p[i, j].Tag = NONE;
                            break;
                        case 3:
                            p[i, j].Image = IBoudouxassignment1.Properties.Resources.boxGreen;
                            p[i, j].Tag = BGREEN;
                            break;
                        case 5:
                            p[i, j].Image = IBoudouxassignment1.Properties.Resources.boxYellow;
                            p[i, j].Tag = BYELLOW;
                            break;
                        case 2:
                            p[i, j].Image = IBoudouxassignment1.Properties.Resources.boxBlue;
                            p[i, j].Tag = BBLUE;
                            break;
                        case 4:
                            p[i, j].Image = IBoudouxassignment1.Properties.Resources.boxRed;
                            p[i, j].Tag = BRED;
                            break;
                        case 7:
                            p[i, j].Image = IBoudouxassignment1.Properties.Resources.doorGreen;
                            p[i, j].Tag = DGREEN;
                            break;
                        case 9:
                            p[i, j].Image = IBoudouxassignment1.Properties.Resources.doorYellow;
                            p[i, j].Tag = DYELLOW;
                            break;
                        case 6:
                            p[i, j].Image = IBoudouxassignment1.Properties.Resources.doorBlue;
                            p[i, j].Tag = DBLUE;
                            break;
                        case 8:
                            p[i, j].Image = IBoudouxassignment1.Properties.Resources.doorRed;
                            p[i, j].Tag = DRED;
                            break;
                        case 1:
                            p[i, j].Image = IBoudouxassignment1.Properties.Resources.wall;
                            p[i, j].Tag = WALL;
                            break;
                        default:
                            break;
                    }
                    this.Controls.Add(p[i, j]);
                    y += HEIGHT;
                }
                x += WIDTH;
            }
        }
        /// <summary>
        /// Open the file and load the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.DefaultExt = ".txt";
            DialogResult result = dlgOpen.ShowDialog();
            switch (result)
            {
                case DialogResult.Abort:
                    break;
                case DialogResult.Cancel:
                    break;
                case DialogResult.Ignore:
                    break;
                case DialogResult.No:
                    break;
                case DialogResult.None:
                    break;
                case DialogResult.OK:
                    try
                    {
                        string filename = dlgOpen.FileName;
                        LoadFile(filename);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error in file load");
                    }
                    break;
                case DialogResult.Retry:
                    break;
                case DialogResult.Yes:
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Load function to load the grid 
        /// </summary>
        /// <param name="fileName"></param>
        private void LoadFile(string fileName)
        {
            StreamReader reader;
            reader = new StreamReader(fileName);

            numberOfRows = int.Parse(reader.ReadLine());
            numberOfCols = int.Parse(reader.ReadLine());
            Generate(reader);
            reader.Close();
        }
        /// <summary>
        /// Move Up function to move the Box up
        /// </summary>
        private void MoveUp()
        {
            while (p[actualRow, actualCol - 1].Image == null) //Se a imagem da esquerda (mesma row e coluna -1) for null, quer dizer que é um espaço vazio, então o Tile pode mover
            {               
                    SwapPictureBoxes(actualRow, actualCol, actualRow, actualCol - 1);
                    actualCol--;              
            }
        }
        /// <summary>
        /// Move  function to move the Box Down
        /// </summary>
        private void MoveDown()
        {
            while (p[actualRow, actualCol + 1].Image == null) //Se a imagem da esquerda (mesma row e coluna -1) for null, quer dizer que é um espaço vazio, então o Tile pode mover
            {
                SwapPictureBoxes(actualRow, actualCol, actualRow, actualCol+1);
                actualCol++;
            }         
        }
        /// <summary>
        /// Move  function to move the Box Left
        /// </summary>
        private void MoveLeft()
        {

            while (p[actualRow-1, actualCol].Image == null) 
            {
                SwapPictureBoxes(actualRow, actualCol, actualRow-1, actualCol);
                actualRow--;
            }
           
        }
        /// <summary>
        /// Move  function to move the Box Right
        /// </summary>
        private void MoveRight()
        {
     
                while (p[actualRow + 1, actualCol].Image == null) //Se a imagem da esquerda (mesma row e coluna -1) for null, quer dizer que é um espaço vazio, então o Tile pode mover
                {
                    SwapPictureBoxes(actualRow, actualCol, actualRow + 1, actualCol);
                    actualRow++;
                }
            
            
        }
        /// <summary>
        /// Method for Swaping the picture boxes 
        /// </summary>
        /// <param name="previousRow"></param>
        /// <param name="previousCol"></param>
        /// <param name="nextRow"></param>
        /// <param name="nextCol"></param>
        private void SwapPictureBoxes(int previousRow, int previousCol, int nextRow, int nextCol)
        {
            
            { p[nextRow, nextCol].Image = p[previousRow, previousCol].Image;
                p[previousRow, previousCol].Image = null;
            }
        }

        /// <summary>
        /// To get the position of the picturebox clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void P_Click(object sender, EventArgs e)
        { 

            selectPicture = (PictureBox)sender;
            bool shouldBreak = false; 
            if (sender is PictureBox)
            {
                for (int i = 0; i < numberOfRows; i++)
                {
                    for (int j = 0; j < numberOfCols; j++)
                    {
                        if (p[i, j].Tag == selectPicture.Tag)
                        {
                             actualRow = i;
                             actualCol = j;
                             shouldBreak = true;
                              break;               
                        }

                    }
                    if (shouldBreak)
                    {
                        break;
                    }
                }
            }
        }

        /// <summary>
        /// button to move the box Up
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnUp_Click_1(object sender, EventArgs e)
        {

            MoveUp(); 
        }
        /// <summary>
        /// button to move the box Down
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDown_Click(object sender, EventArgs e)
        {
            MoveDown();
        }
        /// <summary>
        /// button to move the box Left
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeft_Click(object sender, EventArgs e)
        {
            MoveLeft();
        }
        /// <summary>
        /// button to move the box Right
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRight_Click(object sender, EventArgs e)
        {
            MoveRight();
        }
    }
}
