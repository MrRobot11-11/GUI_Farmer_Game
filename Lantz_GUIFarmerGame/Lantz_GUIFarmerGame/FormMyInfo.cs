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
    public partial class FormMyInfo : Form
    {
        public FormMyInfo()
        {
            InitializeComponent();
           
        }

        private void FormMyInfo_Load(object sender, EventArgs e)
        {
            lblDateTimeActual.Text = System.DateTime.Now.ToString("dddd, dd MMM yyyy hh:mm tt");
        }

        private void btnOkInfo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
