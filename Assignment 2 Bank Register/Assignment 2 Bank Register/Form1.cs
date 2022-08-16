using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_2_Bank_Register
{
    public partial class Form1 : Form
    {
        //Class level variables
        private double account = 100001;
        private double starting;
        private double deposit;
        private double withdrawl;
        private double balance;

        //List collection
        List<Transaction> transactions = new List<Transaction>();
        public Form1()
        {
            InitializeComponent();
        }
        private void HideShowControls(bool bln)
        {
            //Hiding Display
            lbl_account.Visible = bln;
            txt_account.Visible = bln;
            lbl_balance.Visible = bln;
            txt_balance.Visible = bln;
            lbl_deposit.Visible = bln;
            txt_deposit.Visible = bln;
            lbl_withdrawl.Visible = bln;
            txt_withdrawl.Visible = bln;
            btn_update.Visible = bln;
            txt_display.Visible = bln;
            btn_display.Visible = bln;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            HideShowControls(false);
        }
        private void Btn_create_Click(object sender, EventArgs e)
        {
            if (txt_name.Text == string.Empty)
            {
                MessageBox.Show("Enter Name", "Name");
            }
            else if (double.TryParse(txt_starting.Text, out starting) == false)
            {
                MessageBox.Show("Amount incorrect", "Amount");
            }
            else
            {
                txt_display.Clear();
                txt_account.Text = account.ToString();
                lbl_starting.Visible = false;
                txt_starting.Visible = false;
                HideShowControls(true);
                account += 1;
                balance = starting;
                txt_balance.Text = $"{balance:C}";
            }
        }
        private void Btn_update_Click(object sender, EventArgs e)
        {
            string deposit_amount = txt_deposit.Text;
            string withdrawl_amount = txt_withdrawl.Text;
            
            if (deposit_amount == "" && withdrawl_amount == "")
            {
                MessageBox.Show("Atleast one field must contain an amount");
                return;
            }
            if (deposit_amount != "" && withdrawl_amount != "")
            {
                MessageBox.Show("Cannot Deposit and Withdrawl simultaneously");
                return;
            }
            if (withdrawl_amount != "")
            {
                if (double.TryParse(txt_withdrawl.Text, out withdrawl) == false)
                {
                    MessageBox.Show("Amount incorrect", "Amount");
                    return;
                }
                else
                {
                    AddWithdrawl(withdrawl);
                    txt_withdrawl.Clear();
                    return;
                }
            }
            if (deposit_amount != "")
            {
                if (double.TryParse(txt_deposit.Text, out deposit) == false)
                {
                    MessageBox.Show("Amount incorrect", "Amount");
                    return;
                }
                else
                {
                    AddDeposit(deposit);
                    txt_deposit.Clear();
                    return;
                }
            }
        }
        private void AddDeposit(double amount)
        {
            balance += amount;
            txt_balance.Text = $"{balance:C}";

            //Transaction Collection
            Transaction transaction = new Transaction();
            transaction.Amount = amount;
            transaction.Balance = balance;
            transaction.Type = "Deposit";
            transactions.Add(transaction);
        }
        private void AddWithdrawl(double amount)
        {
            balance -= amount;
            txt_balance.Text = $"{balance:C}";

            //Transaction Collection
            Transaction transaction = new Transaction();
            transaction.Amount = amount;
            transaction.Balance = balance;
            transaction.Type = "Withdrawl";
            transactions.Add(transaction);
        }
        private void btn_display_Click(object sender, EventArgs e)
        {
            string output = string.Empty;

            output += "Type\tAmount\tBalance\r\n";

            foreach (Transaction transaction in transactions)
            {
                output += $"{transaction.Type:C}\t{transaction.Amount:C}\t{transaction.Balance:C}\r\n";
            }

            txt_display.Text = output;
        }
        private void Btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
