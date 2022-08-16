using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace Assignment12DecoCompany
{
    class DecoCompany
    {
        string[] companyNames;
        double[] amountOwed;
        string companyName;
        public string[] CompanyNames
        {
            set { companyNames = value; }
        }
        public double[] AmountedOwed
        {
            set { amountOwed = value; }
        }
        public string CompanyName
        {
            set { companyName = value; }
        }
        public void FindCompany()
        {
            for (int i = 0; i < companyNames.Length; i++)
            {
                if (companyNames[i] == companyName.ToUpper())
                {
                    WriteLine("\n******************************************************");
                    WriteLine($"{companyNames[i]}\nPayable Amount is {amountOwed[i]:C}");
                    return;
                }
            }
            WriteLine("\n******************************************************");
            WriteLine("Company not found");
        }
        public override string ToString()
        {
            string str = string.Empty;

            WriteLine("Name\tPayable");
            for (int i = 0; i < companyNames.Length; i++)
            {
                WriteLine($"{companyNames[i]}\t{amountOwed[i]:C}");
            }
            WriteLine("******************************************************");
            return str;
        }
    }
}