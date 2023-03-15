using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Steven Lantz
*ITDEV-115-501
*Fall 2019
*Assignment 7: GUI Farmer Game*/

namespace Lantz_GUIFarmerGame
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            
            Application.Run(new FormMyInfo());
            Application.Run(new FormGameLogic());
            Application.Run(new FormPlayAgain());
            
        }
    }
}
