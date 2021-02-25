using System;

using System.Windows.Forms;
/*
 Take in user wind speed in MPH and output weather it is a class 4,3,2 or 1 Hurricane.
 Category 5 hurricanes have sustained winds of at least 157 miles per hour. The minimum sustained wind speeds for 
 categories 4 through 1 are 130, 111, 96, and 74 miles per hour, respectively. Any storm with winds of less than 74
 miles per hour is not a hurricane.
 */
namespace Hurricane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void windSpeed_TextChanged(object sender, EventArgs e)
        {
            //Used for the user input
        }

        private void hurcCatagory_TextChanged(object sender, EventArgs e)
        {
            //Used for outputting the Hurricane Cat. 
            
        }

        private void runProg_Click(object sender, EventArgs e)
        {
            var speed = Convert.ToDouble(windSpeed.Text);

            //Hurricane.Text sends data to output text box
            if (speed < 74)
            {
                hurcCatagory.Text = "Not a Hurc";
            }

            else if (speed >= 74 && speed < 96)
            {
                hurcCatagory.Text = "Cat 1 Hurc";
            }

            else if (speed >= 96 && speed < 111)
            {
                hurcCatagory.Text = "Cat 2 Hurc";
            }

            else if (speed >= 111 && speed < 130)
            {
                hurcCatagory.Text = "Cat 3 Hurc";
            }
            else if (speed >= 130 && speed < 157)
            {
                hurcCatagory.Text = "Cat 4 Hurc";
            }

            else
            {
                hurcCatagory.Text = "Cat 5 Hurc";
            }
        }

        private void closeProg_Click(object sender, EventArgs e)
        {
            Close();//Button used to close program. If user does not want to use (x). 
        }
    }
}
