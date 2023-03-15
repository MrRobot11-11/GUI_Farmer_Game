using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Windows.Forms;
/*Steven Lantz
*ITDEV-115-501
*Fall 2019
*Assignment 7: GUI Farmer Game*/

namespace Lantz_GUIFarmerGame
{


    class Farmer
    {
        public Farmer()
        {
            northBank.Add("Fox");
            northBank.Add("Chicken");
            northBank.Add("Grain");
            
        }

        //Fields
        public enum Direction
        {
        North,
        South
        };

        private ArrayList northBank = new ArrayList();
        private ArrayList southBank = new ArrayList();
        //private Direction farmer;

        //Properties
        public ArrayList NorthBank { get => northBank; set => northBank = value; }
        public ArrayList SouthBank { get => southBank; set => southBank = value; }
        public Direction TheFarmer { get; set; }

        //Return true if animal ate the food
        public void AnimalAteFood()
        {
            if ((northBank.Contains("Fox")
                && northBank.Contains("Chicken"))
                && TheFarmer != Direction.North)
            {
                MessageBox.Show("Aw man!" +
                                                        "Fox ate the chicken!" +
                                                         "\nGAME OVER");

               
            }
            if ((southBank.Contains("Fox")
                && southBank.Contains("Chicken"))
                && TheFarmer != Direction.South)
            {
                MessageBox.Show("Aw man!" +
                                                         "Fox ate the chicken!" +
                                                        "/nGAME OVER");

            }

            if (northBank.Contains("Chicken")
                && northBank.Contains("Grain")
                && TheFarmer != Direction.North)
            {
                MessageBox.Show("Aw man!" +
                                                        "Chicken ate the grain!" +
                                                         "/nGAME OVER");

            }

            if ((southBank.Contains("Chicken")
                && southBank.Contains("Grain"))
                && TheFarmer != Direction.South)
            {
                MessageBox.Show("Aw man!" +
                                                     "Chicken ate the grain!" +
                                                            "/nGAME OVER");

            }
           
        }

        //Return true if game is won
        public bool DetermineWin()
        {
            if (southBank.Contains("Fox")
                && southBank.Contains("Grain")
                && southBank.Contains("Chicken"))
            {
                MessageBox.Show("You win!!!" +
                                                        "'\nNice Job!");

                return true;
            }
            else
                return false;
        }

        //Test user choice for location of value
        //Take user choice and move it to other side of river
        public void Move(String userChoice)
        {
            while (true)
            {
                if (TheFarmer == Direction.North)
                {
                    if (northBank.Contains(userChoice))
                    {
                        northBank.Remove(userChoice);
                        southBank.Add(userChoice);
                        TheFarmer = Direction.South;

                        break;
                    }
                    else if (!northBank.Contains(userChoice) && !String.IsNullOrEmpty(userChoice))
                    {
                        MessageBox.Show("That item is not on this side of the river." +
                                                                "\nPlease try again...");

                        break;
                    }
                   else
                       
                    TheFarmer = Direction.South;

                    break;
                }

                if (TheFarmer == Direction.South)
                {
                    if (southBank.Contains(userChoice))
                    {
                        southBank.Remove(userChoice);
                        northBank.Add(userChoice);
                        TheFarmer = Direction.North;
                        
                        break;
                    }
                    else if (!southBank.Contains(userChoice) && !String.IsNullOrEmpty(userChoice))
                    {
                        MessageBox.Show("That item is not on this side of the river." +
                                                               "\nPlease try again.");
                        break;
                    }
                    else
                        TheFarmer = Direction.North;
                  
                    break;
                }
            }
        }//End of Move()

        //Boolean test for game status
        //public bool GameOver()
        //{
        //    if (AnimalAteFood() == true || DetermineWin() == true)
        //        return true;
        //    else
        //        return false;
        //}






    }//End of class
}//End of namespace
