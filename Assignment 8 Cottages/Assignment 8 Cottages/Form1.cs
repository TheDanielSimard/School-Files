using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Assignment_8_Cottages
{
    public partial class Form1 : Form
    {
        private OleDbDataAdapter reservationDataAdapter;
        private DataSet reservationDS;
        private OleDbCommandBuilder cBuilder;
        private OleDbConnection dbConn;
        private OleDbCommand dbCmd;
        private string sConnection;
        private string sql;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            sConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" +
                    "Data Source=Cottages.accdb";
            dbConn = new OleDbConnection(sConnection);
            
            sql = "select * from tblReservations order by GuestName ASC";
            dbCmd = new OleDbCommand();
            dbCmd.CommandText = sql;
            dbCmd.Connection = dbConn;

            reservationDataAdapter = new OleDbDataAdapter();
            reservationDataAdapter.SelectCommand = dbCmd;
            reservationDS = new DataSet();
            reservationDataAdapter.Fill(reservationDS, "tblReservations");

            dgvReservation.DataSource = reservationDS;
            dgvReservation.DataMember = "tblReservations";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                cBuilder = new OleDbCommandBuilder(reservationDataAdapter);
                reservationDataAdapter.Update(reservationDS, "tblReservations");
                MessageBox.Show("Reservations updated", "Reservations");
            }
            catch(SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteRecord_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dlgResults;
                dlgResults = MessageBox.Show("Delete Record", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (dlgResults == DialogResult.Yes)
                {
                    dgvReservation.Rows.Remove(dgvReservation.CurrentRow);

                    btnUpdate_Click(sender, e);
                }
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dlgResults;
            dlgResults = MessageBox.Show("Exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (dlgResults == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
