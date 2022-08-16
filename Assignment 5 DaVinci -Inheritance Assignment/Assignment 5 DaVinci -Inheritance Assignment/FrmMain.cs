using System;
using System.Windows.Forms;
using Assignment_5_Classes;

namespace Assignment_5_DaVinci__Inheritance_Assignment
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            //Hiding Sections On Startup
            grpHousing.Visible = false;
            chkAuto.Visible = false;

            //Radio Buttons Set To False, Setting To True
            radLondon.AutoCheck = true;
            radOffCampus.AutoCheck = true;
            radOnCampus.AutoCheck = true;
            radParis.AutoCheck = true;
            radRome.AutoCheck = true;
        }

        private void radOffCampus_CheckedChanged(object sender, EventArgs e)
        {
            grpHousing.Visible = false;
            chkAuto.Visible = true;
        }

        private void radOnCampus_CheckedChanged(object sender, EventArgs e)
        {
            chkAuto.Visible = false;
            grpHousing.Visible = true;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //If Good Data Code Proceeds
            errProvider.Clear();

            bool hasErrors = false;

            if (txtID.Text == string.Empty)
            {
                errProvider.SetError(txtID, "ID Needed");
                txtID.Focus();

                hasErrors = true;
            }

            if (!int.TryParse(txtID.Text, out var id))
            {
                errProvider.SetError(txtID, "ID Must Be Numbers");
                txtID.Focus();

                hasErrors = true;
            }

            if (txtName.Text == string.Empty)
            {
                errProvider.SetError(txtName, "Name Needed");
                txtName.Focus();

                hasErrors = true;
            }

            if (txtNumberCredits.Text == string.Empty)
            {
                errProvider.SetError(txtNumberCredits, "Number Of Credits Needed");
                txtNumberCredits.Focus();

                hasErrors = true;
            }

            if (!int.TryParse(txtNumberCredits.Text, out var numCredits))
            {
                errProvider.SetError(txtNumberCredits, "Number Of Credits Must Be Numbers");
                MessageBox.Show("Credits Error", "Credits");
                txtNumberCredits.Focus();

                hasErrors = true;
            }

            if (!radOffCampus.Checked && !radOnCampus.Checked)
            {
                errProvider.SetError(grpResidence, "Select Residence Type");
                grpResidence.Focus();

                hasErrors = true;
            }

            if (radOnCampus.Checked && !radLondon.Checked && !radParis.Checked && !radRome.Checked)
            {
                errProvider.SetError(grpHousing, "Select Housing Type");
                grpHousing.Focus();

                hasErrors = true;
            }

            if (!hasErrors)
            {
                ProcessData(id, txtName.Text, numCredits);
            }
        }

        private void ProcessData(int id, string name, int numCredits)
        {
            Student student;
            Housing housing;

            if (radOffCampus.Checked)
            {
                student = new OffCampus(id, name, numCredits, chkAuto.Checked);
            }
            else
            {
                if (radLondon.Checked)
                {
                    housing = Housing.London;
                }
                else if (radParis.Checked)
                {
                    housing = Housing.Paris;
                }
                else
                {
                    housing = Housing.Rome;
                }

                student = new OnCampus(id, name, numCredits)
                {
                    Housing = housing
                };
            }
            txtTuition.Text = student.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}