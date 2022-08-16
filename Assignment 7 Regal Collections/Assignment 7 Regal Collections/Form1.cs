using System;
using System.Windows.Forms;
namespace Assignment_7_Regal_Collections
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private InvoiceCollection aInvoiceCollection = new InvoiceCollection();

        private InvoiceFile aInvoiceFile = new InvoiceFile();

        private void FillCombo()
        {
            cboInvoiceNumber.Items.Clear();
            foreach (Invoice invoice in aInvoiceCollection.AllInvoices)
            {
                cboInvoiceNumber.Items.Add(invoice.invoiceNumber);
                cboInvoiceNumber.Text = invoice.invoiceNumber;
            }
        }

        private void cboInvoiceNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            Invoice aInvoice;
            aInvoice = aInvoiceCollection.FindInvoice(cboInvoiceNumber.Text);
            if (aInvoice == null)
            {
                MessageBox.Show("Not Found", "Error");
            }
            else
            {
                txtID.Text = aInvoice.id;
                txtAmount.Text = aInvoice.amount.ToString("c");
                txtDate.Text = aInvoice.date;
            }
        }
        private void ReadOnlyInputs(bool bln)
        {
            txtID.ReadOnly = bln;
            txtAmount.ReadOnly = bln;
            txtDate.ReadOnly = bln;
            btnFindInvoice.Enabled = bln;
        }

        private void btnAddSave_Click(object sender, EventArgs e)
        {
            //Need to have first invoice auto displayed after saving an invoice
            if (btnAddSave.Text == "Add")
            {
                ReadOnlyInputs(false);
                btnAddSave.Text = "Save";
                btnRemoveCancel.Text = "Cancel";
                cboInvoiceNumber.Text = string.Empty;
                txtID.Clear();
                txtAmount.Clear();
                txtDate.Clear();
                cboInvoiceNumber.Focus();
            }
            else
            {
                try
                {
                    if (txtID.Text != string.Empty && txtAmount.Text != string.Empty && txtDate.Text != string.Empty && cboInvoiceNumber.Text != string.Empty)
                    {
                        Invoice newInvoice = new Invoice();
                        newInvoice.invoiceNumber = cboInvoiceNumber.Text;
                        newInvoice.id = txtID.Text;
                        newInvoice.amount = Double.Parse(txtAmount.Text);
                        newInvoice.date = txtDate.Text;
                        aInvoiceCollection.AddInvoice(newInvoice);
                        FillCombo();
                        
                        ReadOnlyInputs(true);
                        btnAddSave.Text = "Add";
                        btnRemoveCancel.Text = "Remove";
                    }
                    else
                    {
                        MessageBox.Show("Data Missing", "Error");
                    }
                }
                catch
                {
                    MessageBox.Show("Duplicate Number", "Error");
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aInvoiceFile.ReadFile(aInvoiceCollection);
            FillCombo();
        }

        private void btnRemoveCancel_Click(object sender, EventArgs e)
        {
            if (btnRemoveCancel.Text == "Cancel")
            {
                btnAddSave.Text = "Add";
                btnRemoveCancel.Text = "Remove";
            }
            else
            {
                DialogResult dlgResults;
                dlgResults = MessageBox.Show("Remove Invoice", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (dlgResults == System.Windows.Forms.DialogResult.Yes)
                {
                    aInvoiceCollection.RemoveInvoice(cboInvoiceNumber.Text);
                    cboInvoiceNumber.Text = string.Empty;
                    txtID.Clear();
                    txtAmount.Clear();
                    txtDate.Clear();
                    FillCombo();
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgResults;
            dlgResults = MessageBox.Show("Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (dlgResults == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                aInvoiceFile.WriteFile(aInvoiceCollection);
            }
        }

        private void txtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool bln = false;
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '\b':
                case '.':
                    bln = true;
                    break;
            }

            if (bln == false) e.Handled = true;
        }

        private void txtDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool bln = false;
            switch (e.KeyChar)
            {
                case '1':
                case '2':
                case '3':
                case '4':
                case '5':
                case '6':
                case '7':
                case '8':
                case '9':
                case '0':
                case '\b':
                case '/':
                    bln = true;
                    break;
            }

            if (bln == false) e.Handled = true;
        }

        private void btnDisplayAll_Click(object sender, EventArgs e)
        {
            frmDisplay frm = new frmDisplay();
            frm.aInvoice = aInvoiceCollection;
            frm.Show();
        }

        private void btnTotalInvoices_Click(object sender, EventArgs e)
        {
            double totalAmount;
            totalAmount = aInvoiceCollection.TotalAmount();
            MessageBox.Show($"Total Amount Of Invoices > {totalAmount:C}");
        }

        private void btnFindInvoice_Click(object sender, EventArgs e)
        {
            Invoice find;
            find = aInvoiceCollection.FindInvoice(txtFindInvoice.Text);
            if (find == null)
            {
                MessageBox.Show("Not Found", "Find");
            }
            else
            {
                cboInvoiceNumber.Text = find.invoiceNumber;
            }
            txtFindInvoice.Clear();
        }

        private void tlExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
