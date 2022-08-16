using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_1_Nifty_Repair_Service
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        //Class level variables
        private double hours;
        private double costofparts;

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtDisplay.Visible = false; //Hiding display 
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //Data vailidation
            if(txtName.Text == string.Empty)
            {
                MessageBox.Show("Name error", "Error");
            }
            else if (double.TryParse(txtHours.Text, out hours) == false)
            {
                MessageBox.Show("Hours error", "Error");
            }
            else if (double.TryParse(txtCostofparts.Text, out costofparts) == false)
            {
                MessageBox.Show("Parts error", "Error");
            }
            else
            {
                //Tests passed
                CalculateCost();
            }
        }
        private void CalculateCost()
        {
            //Variables
            double serviceCost;
            double partsTax;
            double total;

            //CONSTANTS
            const double TAX = .07;

            //Showing display
            txtDisplay.Clear();
            txtDisplay.Visible = true;

            //Finding service cost
            if (hours * 120 > 200)
            {
                serviceCost = hours * 120;
            }
            else
            {
                serviceCost = 200;
            }

            //Calculations
            partsTax = costofparts * TAX;
            total = serviceCost + costofparts + partsTax;

            //Display
            txtDisplay.Text = $"Name: {txtName.Text}\r\n";
            txtDisplay.Text += $"{hours} hours:\t {serviceCost:C}\r\n";
            txtDisplay.Text += $"Parts cost:{costofparts:C}\r\n";
            txtDisplay.Text += $"Parts tax:\t {partsTax:C}\r\n";
            txtDisplay.Text += $"Total:\t {total:C}\r\n";
            txtDisplay.Text += $"Thank you!\r\n";
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
