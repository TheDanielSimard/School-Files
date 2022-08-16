using System.IO;
namespace Assignment_7_Regal_Collections
{
    public class InvoiceFile
    {
        public void WriteFile(InvoiceCollection invoiceColl)
        {
            StreamWriter outfile;
            outfile = File.CreateText("invoice.txt");
            foreach (Invoice aInvoice in invoiceColl.AllInvoices)
            {
                outfile.Write(aInvoice.invoiceNumber);
                outfile.Write(",");
                outfile.Write(aInvoice.id);
                outfile.Write(",");
                outfile.Write(aInvoice.date);
                outfile.Write(",");
                outfile.Write(aInvoice.amount);
                outfile.Write(",");
            }
            outfile.Close();
        }

        public void ReadFile(InvoiceCollection invoiceColl)
        {
            StreamReader infile;
            char delimiter = ',';
            string line;
            string[] fields = new string[4];
            if (File.Exists("invoice.txt"))
            {
                infile = File.OpenText("invoice.txt");
                while (!infile.EndOfStream)
                {
                    line = infile.ReadLine();
                    fields = line.Split(delimiter);
                    Invoice aInvoice = new Invoice();
                    aInvoice.invoiceNumber = fields[0];
                    aInvoice.id = fields[1];
                    aInvoice.date = fields[2];
                    aInvoice.amount = double.Parse(fields[3]);
                    invoiceColl.AddInvoice(aInvoice);
                }
                infile.Close();
            }
        }
    }
}
