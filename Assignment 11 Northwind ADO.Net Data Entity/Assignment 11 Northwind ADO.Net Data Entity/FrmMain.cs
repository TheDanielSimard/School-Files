using System;
using System.Linq;
using System.Windows.Forms;
using System.Data.Entity;
using System.Diagnostics;

namespace Assignment_11_Northwind_ADO.Net_Data_Entity
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private NorthwindEntities dbContext = new NorthwindEntities();

        private void FrmMain_Load(object sender, EventArgs e)
        {
            dbContext.Products.Load();
            productBindingSource.DataSource = dbContext.Products.Local;
        }

        private void btnAllProducts_Click(object sender, EventArgs e)
        {
            dbContext.Products.Load();
            productBindingSource.DataSource = dbContext.Products.Local;
        }

        private void btnReorder_Click(object sender, EventArgs e)
        {
            var products = dbContext.Products.Where(x => x.ReorderLevel > x.UnitsInStock).ToList();
            productBindingSource.DataSource = products;
        }

        private void btnDiscon_Click(object sender, EventArgs e)
        {
            var products = dbContext.Products.Where(x => x.Discontinued).ToList();
            productBindingSource.DataSource = products;
        }
    }
}
