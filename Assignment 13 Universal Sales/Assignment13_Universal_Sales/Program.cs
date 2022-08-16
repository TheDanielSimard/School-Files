using System;
using static System.Console;
namespace Assignment13_Universal_Sales
{
    class Program
    {
        static void Main(string[] args)
        {                          //Names, January(1), Februrary(2), March(3)
            string[,] salesArray = {{"Collier","2500","35000","20000"},
                                    {"Lee","17000","50000","10000"   },
                                    {"Brown","13000","25000","25000" },
                                    {"Cano","55000","35000","30000" }};
            Universal_Sales Universal = new Universal_Sales();
            Universal.DisplayMonths(salesArray);
            Universal.SpecificMonth(salesArray);
            Universal.SpecificPerson(salesArray);
        }
    }
}
