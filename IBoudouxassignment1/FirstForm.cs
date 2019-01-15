using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IBoudouxassignment1
{
    public partial class FirstForm : Form
    {
        public FirstForm()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Button to open the design form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDesign_Click(object sender, EventArgs e)
        {
            QPuzzel formDesign = new QPuzzel();
            formDesign.Show();
        }
        /// <summary>
        /// Button to exit the program
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGame_Click(object sender, EventArgs e)
        {
            playForm formPlay = new playForm();
            formPlay.Show();

        }
    }
}
