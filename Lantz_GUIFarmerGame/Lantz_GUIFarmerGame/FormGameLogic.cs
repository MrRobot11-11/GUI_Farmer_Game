using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
/*Steven Lantz
*ITDEV-115-501
*Fall 2019
*Assignment*/

namespace Lantz_GUIFarmerGame
{
    public partial class FormGameLogic : Form
    {
         Farmer farmer = new Farmer();
        private string northBankValues;
        private string southBankValues;
        private string userChoice;
        Farmer.Direction north = Farmer.Direction.North;
        Farmer.Direction south = Farmer.Direction.South;

        public FormGameLogic()
        {
            InitializeComponent();
     
        }

//Loading of form
        private void FormGameLogic_Load(object sender, EventArgs e)
        {
        }


        //Ok button pressed
        //Holds majority of game logic
       public void btnOkGameScreen_Click(object sender, EventArgs e)
        {

            txtBxNorthBank.Text = getNorthBank();
            txtBxSouthBank.Text = getSouthBank();

            userChoice = this.comboBoxChoose.Text;

            lblGetFarmerLocation.Text = Convert.ToString(farmer.TheFarmer);
 
            ProcessChoice(userChoice);

            txtBxNorthBank.Text = getNorthBank();
            txtBxSouthBank.Text = getSouthBank();

            lblGetFarmerLocation.Text = Convert.ToString(farmer.TheFarmer);
            //MessageBox.Show(getNorthBank());

            if ((farmer.NorthBank.Contains("Fox")
              && farmer.NorthBank.Contains("Chicken"))
              && farmer.TheFarmer != north
              && !farmer.NorthBank.Contains("Grain"))
            {
                MessageBox.Show("Aw man!" +
                                                        " Fox ate the chicken!" +
                                                         "\nGAME OVER");

                this.Close();
            }
            if ((farmer.SouthBank.Contains("Fox")
                && farmer.SouthBank.Contains("Chicken"))
                && farmer.TheFarmer != south
                && !farmer.SouthBank.Contains("Grain"))
            {
                MessageBox.Show("Aw man!" +
                                                         " Fox ate the chicken!" +
                                                        "\nGAME OVER");
                this.Close();

            }

            if (farmer.NorthBank.Contains("Chicken")
                && farmer.NorthBank.Contains("Grain")
                && farmer.TheFarmer != north
                && !farmer.NorthBank.Contains("Fox"))
            {
                MessageBox.Show("Aw man!" +
                                                        " Chicken ate the grain!" +
                                                         "\nGAME OVER");

                this.Close();
            }

            if ((farmer.SouthBank.Contains("Chicken")
                && farmer.SouthBank.Contains("Grain"))
                && farmer.TheFarmer != south
                && !farmer.SouthBank.Contains("Fox"))
            {
                MessageBox.Show("Aw man!" +
                                                     " Chicken ate the grain!" +
                                                            "\nGAME OVER");
                this.Close();
            }

            if (farmer.SouthBank.Contains("Fox")
          && farmer.SouthBank.Contains("Grain")
          && farmer.SouthBank.Contains("Chicken"))
            {
                MessageBox.Show("You win!!!" +
                                                        "\nNice Job!");
                this.Close();
            }

        

        }//end of btnOkGameScreen_Click
        
//Return values from northBank array list
       private string getNorthBank()
        {
            northBankValues = " ";
            foreach(string element in farmer.NorthBank)
            {
                northBankValues += element + " ";
            }
            return northBankValues;
        }
        
//Return values from southBank array list
        private string getSouthBank()
        {
            southBankValues = " ";
            foreach (string element in farmer.SouthBank)
            {
              southBankValues += element + " ";
            }
            return southBankValues;
        }

        private void ProcessChoice(string choice)
        {
            farmer.Move(choice);
        }

        private void comboBoxChoose_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }//End of class
}//End of NameSpace
