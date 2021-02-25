using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void hurcCatagory_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void runProg_Click(object sender, EventArgs e)
        {
            var speed = Convert.ToDouble(windSpeed.Text);

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
            Close();
        }
    }
}
