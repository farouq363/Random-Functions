using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /* Name:Farouk Olatuni
         * Date: November 2024
         * This program rolls one dice or calculates mark stats.
         * Link to your repo in GitHub: 
         * */

        //class-level random object
        Random rand = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            //select one roll radiobutton
           radOneRoll.Checked = true;
            //grpOneRoll.Show();
            //grpMarkStats.Hide();

            //add your name to end of form title
            this.Text = string.Concat(this.Text, " Farouk Olatunji") ;

        } // end form load

        private void btnClear_Click(object sender, EventArgs e)
        {
            //call the function
            ClearOneRoll();
           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //call the function
            ClearStats();
            
        }

        private void btnRollDice_Click(object sender, EventArgs e)
        {
            int dice1, dice2;
            //call ftn RollDice, placing returned number into integers
            dice1 = RollDice();
            dice2 = RollDice();

            //place integers into labels
            lblDice1.Text = dice1.ToString();
            lblDice2.Text = dice2.ToString();

            // call ftn GetName sending total and returning name
            string name = GetName(dice2,dice1);


            //display name in label
            lblRollName.Text = name;

        }

        /* Name: ClearOneRoll
        *  Sent: nothing
        *  Return: nothing
        *  Clear the labels */
        private void ClearOneRoll()
        {
            lblDice1.Text = string.Empty;
            lblDice2.Text= string.Empty;
            lblRollName.Text= string.Empty;


        }


        /* Name: ClearStats
        *  Sent: nothing
        *  Return: nothing
        *  Reset nud to minimum value, chkbox unselected, 
        *  clear labels and listbox */
        private void ClearStats()
        {
            lblPass.Text = string.Empty; 
            lblFail.Text = string.Empty; 
            lblAverage.Text = string.Empty;
            lstMarks.Text = string.Empty;
            chkSeed.Checked = false;
        }


        /* Name: RollDice
        * Sent: nothing
        * Return: integer (1-6)
        * Simulates rolling one dice */
        private int RollDice()
        {
            return rand.Next(1, 6);
        }

        /* Name: GetName
        * Sent: 1 integer (total of dice1 and dice2) 
        * Return: string (name associated with total) 
        * Finds the name of dice roll based on total.
        * Use a switch statement with one return only
        * Names: 2 = Snake Eyes
        *        3 = Litle Joe
        *        5 = Fever
        *        7 = Most Common
        *        9 = Center Field
        *        11 = Yo-leven
        *        12 = Boxcars
        * Anything else = No special name*/
        private string GetName(int firstNumber, int secondNumber)
        {
            int total = firstNumber + secondNumber;
            string result;

            switch (total)
            {
                case 2:
                    result = "Snake Eyes";
                    break;
                case 3:
                    result = "Little Joe";
                    break;
                case 5:
                    result = "Fever";
                    break;
                case 7:
                    result = "Most Common";
                    break;
                case 9:
                    result = "Center Field";
                    break;
                case 11:
                    result = "Yo-leven";
                    break;
                case 12:
                    result = "Boxcars";
                    break;
                default:
                    result = "No special";
                    break;
            }

            return result;
        }


        private void btnSwapNumbers_Click(object sender, EventArgs e)
        {
            //call ftn DataPresent twice sending string returning boolean

            //if data present in both labels, call SwapData sending both strings

            //put data back into labels

            //if data not present in either label display error msg
        }

        /* Name: DataPresent
        * Sent: string
        * Return: bool (true if data, false if not) 
        * See if string is empty or not*/


        /* Name: SwapData
        * Sent: 2 strings
        * Return: none 
        * Swaps the memory locations of two strings*/

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            //declare variables and array

            //check if seed value

            //fill array using random number

            //call CalcStats sending and returning data

            //display data sent back in labels - average, pass and fail
            // Format average always showing 2 decimal places 

        } // end Generate click

        private void radOneRoll_CheckedChanged(object sender, EventArgs e)
        {
            //radRollStats.Checked = false;
            grpMarkStats.Hide();


            //radOneRoll.Checked = true;
            grpOneRoll.Show();


            
           


        }


        private void radRollStats_CheckedChanged(object sender, EventArgs e)
        {
            //radOneRoll.Checked = false;
            grpOneRoll.Hide();


            //radRollStats.Checked = true;
            grpMarkStats.Show();


           
           
          

        }

        /* Name: CalcStats
        * Sent: array and 2 integers
        * Return: average (double) 
        * Run a foreach loop through the array.
        * Passmark is 60%
        * Calculate average and count how many marks pass and fail
        * The pass and fail values must also get returned for display*/

    }
}
