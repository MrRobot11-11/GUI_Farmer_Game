using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Steven Lantz
*ITDEV-115-501
*Fall 2019
*Assignment 7: GUI Farmer Game*/

namespace Lantz_GUIFarmerGame
{
    public partial class FormPlayAgain : Form
    {
       

        public FormPlayAgain()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
