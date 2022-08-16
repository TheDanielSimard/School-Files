using System.Windows.Forms;
namespace Assignment_7_Regal_Collections
{
    public partial class frmDisplay : Form
    {
        public frmDisplay()
        {
            InitializeComponent();
        }

        public InvoiceCollection aInvoice = new InvoiceCollection();

        private void frmDisplay_Load(object sender, System.EventArgs e)
        {
            txtNewDisplay.Text = aInvoice.ToString();
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
    }
}
