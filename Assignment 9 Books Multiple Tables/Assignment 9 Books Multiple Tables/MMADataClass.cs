namespace Assignment_9_Books_Multiple_Tables
{
    class MMADataClass
    {
        MMABooksDataSetTableAdapters.InvoicesTableAdapter invoicesTableAdapter;
        MMABooksDataSetTableAdapters.CustomersTableAdapter customersTableAdapter;
        MMABooksDataSet mmaDataSet;

        public MMABooksDataSet GetDataSet()
        {
            invoicesTableAdapter = new MMABooksDataSetTableAdapters.InvoicesTableAdapter();
            customersTableAdapter = new MMABooksDataSetTableAdapters.CustomersTableAdapter();
            mmaDataSet = new MMABooksDataSet();

            invoicesTableAdapter.Fill(mmaDataSet.Invoices);
            customersTableAdapter.Fill(mmaDataSet.Customers);
            return mmaDataSet;
        }
    }
}
