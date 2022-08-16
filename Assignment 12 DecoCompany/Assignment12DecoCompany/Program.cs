using System;
using static System.Console;
namespace Assignment12DecoCompany
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] companyNames = { "OXONY", "CORE", "ITECH", "APPLE" };
            double[] amountOwed = { 25000, 37000, 10000, -500 };

            Header_Instructions();

            DecoCompany Company = new DecoCompany();
            Company.CompanyNames = companyNames;
            Company.AmountedOwed = amountOwed;

            Write(Company);

            Write("Enter name of company: ");
            Company.CompanyName = ReadLine();

            Company.FindCompany();

            Read();
        }
        private static void Header_Instructions()
        {
            string date = DateTime.Today.ToShortDateString();
            WriteLine("******************************************************");
            WriteLine("\tAccounts Payable");
            WriteLine("\tList accounts payable with total money owed,");
            WriteLine("\tand determine money owed by a specific company");
            WriteLine("\tDaniel Simard");
            WriteLine($"\t{date}");
            WriteLine("******************************************************");
            WriteLine("This program will display a list of accounts payable");
            WriteLine("and total money owed.");
            WriteLine("It will also find money owed for a specific account.");
            WriteLine("When prompted enter company's name to determine money");
            WriteLine("owed by that company.");
            WriteLine("******************************************************");
        }
    }
}
