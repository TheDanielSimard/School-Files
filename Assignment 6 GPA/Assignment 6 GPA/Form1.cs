using System;
using System.Windows.Forms;
namespace Assignment_6_GPA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ProjectedGPA aProjectedGPA = new ProjectedGPA();

        bool inputError = false;

        private void CheckInput()
        {
            inputError = false;

            try
            {
                aProjectedGPA.Points = double.Parse(txtPoints.Text);
                aProjectedGPA.Credits = double.Parse(txtCredits.Text);
            }

            catch
            {
                MessageBox.Show("Input Error", "Error");
                inputError = true;
            }
        }

        private void btnInterface_Click(object sender, EventArgs e)
        {
            CheckInput();
            if (!inputError)
            {
                txtDisplay.Text = $"GPA using interface is {aProjectedGPA.CalculateGPA()}";
            }
        }

        private void btnDelegate_Click(object sender, EventArgs e)
        {
            CheckInput();
            if (!inputError)
            {
                txtDisplay.Text = aProjectedGPA.ToString();
            }
        }

        private void btnLambdaExpression_Click(object sender, EventArgs e)
        {
            CheckInput();
            if (!inputError)
            {
                txtDisplay.Text = aProjectedGPA.msg();
            }
        }

        private void btnLambda_Click(object sender, EventArgs e)
        {
            CheckInput();
            if (!inputError)
            {
                txtDisplay.Text = aProjectedGPA.results();
            }
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == string.Empty)
            {
                MessageBox.Show("Input Error", "Error");
            }
            else
            {
                txtDisplay.Text = aProjectedGPA.ValidateID(txtID.Text);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
