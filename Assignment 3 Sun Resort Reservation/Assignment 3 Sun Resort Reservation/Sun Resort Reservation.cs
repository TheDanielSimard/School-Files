using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3_Sun_Resort_Reservation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Credit Card Box Selections
            lstCreditCard.Items.Add("Visa");
            lstCreditCard.Items.Add("MasterCard");
            lstCreditCard.Items.Add("American Express");

            //Date Scheduluer Defaults
            dtpIn.MinDate = DateTime.Today;
            dtpOut.MinDate = DateTime.Today.AddDays(1);
            dtpOut.MaxDate = DateTime.Today.AddYears(1);

            //Radio Auto Set To False, Setting Them To True
            radKing.AutoCheck = true;
            radQueen.AutoCheck = true;
            radDouble.AutoCheck = true;
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            //Menu Display
            MessageBox.Show("Sun Resorts Is A Fabulous Vacation Paradise Located On Blue Waters!");
        }

        private void mnuContact_Click(object sender, EventArgs e)
        {
            //Menu Display
            MessageBox.Show("Contact Us At SunResorts@gmail.com");
        }

        private void dtpIn_ValueChanged(object sender, EventArgs e)
        {
            //Updating Dates
            dtpOut.MinDate = dtpIn.Value.AddDays(1);
        }

        private void btnReservation_Click(object sender, EventArgs e)
        {
            //Error If No Data Provided (Name & Bed Type)
            errProvider.Clear();
            if (txtName.Text == string.Empty)
            {
                errProvider.SetError(txtName, "Name Needed");
                txtName.Focus();
                return;
            }
            else
            {
                if (radKing.Checked || radQueen.Checked || radDouble.Checked)
                {
                    GoodData();
                }
                else
                {
                    errProvider.SetError(grpBox, "Select Bed Size");
                    grpBox.Focus();
                    return;
                }
            }
        }

        private void GoodData()
        {
            try
            {
                RoomRate aRoomRate = new RoomRate();

                aRoomRate.Name = txtName.Text;
                aRoomRate.DateIn = dtpIn.Value;
                aRoomRate.DateOut = dtpOut.Value;
                aRoomRate.Discount = chkMember.Checked;

                if (radKing.Checked)
                {
                    aRoomRate.Bed = BedSize.King;
                }
                else
                {
                    if (radQueen.Checked)
                    {
                        aRoomRate.Bed = BedSize.Queen;
                    }
                    else
                    {
                        aRoomRate.Bed = BedSize.Double;
                    }
                }

                //Display Data
                txtReservation.Text = aRoomRate.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void mnuFileExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
