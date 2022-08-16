using System.Collections.Generic;
namespace Assignment_7_Regal_Collections
{
    public class InvoiceCollection
    {
        Dictionary<string, Invoice> invoiceList = new Dictionary<string, Invoice>();
        public Dictionary<string, Invoice>.ValueCollection AllInvoices
        {
            get { return invoiceList.Values; }
        }

        public void AddInvoice(Invoice invoices)
        {
            invoiceList.Add(invoices.invoiceNumber, invoices);
        }

        public void RemoveInvoice(string invoiceNumber)
        {
            invoiceList.Remove(invoiceNumber);
        }

        public Invoice FindInvoice(string invoiceNumber)
        {
            Invoice find;

            if (invoiceList.ContainsKey(invoiceNumber))
            {
                find = invoiceList[invoiceNumber];
                return find;
            }
            else
            {
                return null;
            }
        }

        public double TotalAmount()
        {
            double total = 0;

            foreach (Invoice item in AllInvoices)
            {
                total += item.amount;
            }
            return total;
        }

        public override string ToString()
        {
            string str = "Invoice#\t\t" + "Customer ID\t" + "Date\t\t" + "Amount\r\n";
            double total = 0;
            
            foreach (Invoice invoices in AllInvoices)
            {
                str += $"{invoices.invoiceNumber}\t\t{invoices.id}\t\t{invoices.date}\t{invoices.amount:C}\r\n";
                total += invoices.amount;
            }

            str += $"Total Amount\t{total:C}";
            return str;
        }
    }
}
