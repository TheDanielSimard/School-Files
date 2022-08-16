using System;
using System.Windows.Forms;
namespace Assignment_9_Books_Multiple_Tables
{
    public partial class FrmMain : Form
    {
        MMABooksDataSet mMABooksDataSet;
        BindingSource invoiceBindingSource;
        BindingSource customersBindingSource;
        MMADataClass mMADataClass;

        Boolean gridInitialized;

        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            mMADataClass = new MMADataClass();
            mMABooksDataSet = mMADataClass.GetDataSet();

            //Binding Source Invoices
            invoiceBindingSource = new BindingSource();
            invoiceBindingSource.DataSource = mMABooksDataSet;
            invoiceBindingSource.DataMember = "Invoices";

            //Binding Source Customers
            customersBindingSource = new BindingSource();
            customersBindingSource.DataSource = mMABooksDataSet;
            customersBindingSource.DataMember = "Customers";

            //Binding Combobox
            cboName.DataSource = customersBindingSource;
            cboName.DisplayMember = "Name";
            cboName.ValueMember = "CustomerID";

            //Binding Other Data Variables To Text Boxes
            cboName.DataBindings.Add("text", customersBindingSource, "Name");
            txtID.DataBindings.Add("text", customersBindingSource, "CustomerID");
            txtAddress.DataBindings.Add("text", customersBindingSource, "Address");
            txtCity.DataBindings.Add("text", customersBindingSource, "City");
            txtState.DataBindings.Add("text", customersBindingSource, "State");
            txtZip.DataBindings.Add("text", customersBindingSource, "ZipCode");

            //Displaying Information On Load
            cboName_SelectionChangeCommitted(cboName, e);
        }

        private void cboName_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string nameSelected;
            nameSelected = Convert.ToString(cboName.SelectedValue);

            if (!gridInitialized)
            {
                invoiceDataGridView.DataSource = invoiceBindingSource;
                gridInitialized = true;

                ChangeGridColumn();
            }

            invoiceBindingSource.Filter = "CustomerID = '" + nameSelected + "'";
        }

        private void ChangeGridColumn()
        {
            //Filling Columns
            invoiceDataGridView.Columns["InvoiceID"].HeaderText = "Invoice ID";
            invoiceDataGridView.Columns["CustomerID"].HeaderText = "Customer ID";
            invoiceDataGridView.Columns["InvoiceDate"].HeaderText = "Invoice Date";
            invoiceDataGridView.Columns["ProductTotal"].HeaderText = "Product Total";
            invoiceDataGridView.Columns["SalesTax"].HeaderText = "Sales Tax";
            invoiceDataGridView.Columns["Shipping"].HeaderText = "Shipping";
            invoiceDataGridView.Columns["InvoiceTotal"].HeaderText = "Invoice Total";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
