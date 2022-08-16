//Daniel Simard
//November 10th, 2021
//Assignment 10 Savings
//Calculate Compound Interest
using System;
using static System.Console;
namespace Assignment10Savings
{
    class Compounding_Interest_Calculator
    {
        static void Main(string[] args)
        {
            Header_Instructions();

            Savings();

            Read();
        }
        static void Header_Instructions()
        {
            string date = DateTime.Today.ToShortDateString();
            WriteLine("******************************************" +
                "\n\tSavings" +
                "\n\tCalculate Compound Interest" +
                "\n\tDaniel Simard" +
               $"\n\t{date}" +
                "\n******************************************" +
                "\nThis program will calculate savings" +
                "\nfor a 5 year period." +
                "\n\nEnter the amount saved" +
                "\n******************************************");
        }
        private static void Savings()
        {
            string inputValue;
            double interest;
            string name;
            const double COMPOUND_INTEREST = 1.05;

            Write("Enter name or stop to quit: ");
            name = ReadLine();
            while (name != "stop")
            {
                Write("Enter amount: ");
                inputValue = ReadLine();

                if (int.TryParse(inputValue, out int saved) == false)
                {
                    WriteLine("Invalid input");
                }
                else
                {
                    interest = saved;
                    for (int i = 1; i < 6; i++)
                    {
                        interest *= COMPOUND_INTEREST;
                        WriteLine($"Year {i} {interest:C}");
                    }
                    WriteLine("******************************************");
                }
                Write("Enter name or stop to quit: ");
                name = ReadLine();
            }
        }
    }
}