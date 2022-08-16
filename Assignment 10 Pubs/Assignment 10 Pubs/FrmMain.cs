using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
namespace Assignment_10_Pubs
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void salesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pubsDataSet);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.salesTableAdapter.Fill(this.pubsDataSet.sales);
        }

        private void btnStoreID_Click(object sender, EventArgs e)
        {
            salesTableAdapter.FillByStoreID(pubsDataSet.sales, txtStoreID.Text);
        }

        private void btnTopAllRecords_Click(object sender, EventArgs e)
        {
            this.salesTableAdapter.Fill(this.pubsDataSet.sales);
        }

        private void btnGetOrderNumber_Click(object sender, EventArgs e)
        {
            var records = from sale in pubsDataSet.sales
                          where sale.ord_num.ToUpper() == txtOrderNumber.Text.ToUpper()
                          select sale;

            salesBindingSource.DataSource = records.AsDataView();
        }

        private void btnGetQuantity_Click(object sender, EventArgs e)
        {
            double total =
                (from sale in pubsDataSet.sales
                 where sale.ord_num.ToUpper() == txtOrderNumber.Text.ToUpper()
                 select (int)sale.qty).Sum();
            
            MessageBox.Show($"Total quantity is {total}");
        }

        private void btnAllRecords_Click(object sender, EventArgs e)
        {
            var records = from sale in pubsDataSet.sales
                          select sale;

            salesBindingSource.DataSource = records.AsDataView();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
