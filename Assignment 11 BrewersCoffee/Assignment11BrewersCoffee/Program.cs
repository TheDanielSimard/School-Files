//Daniel Simard
//November 17th, 2021
//Assignment - Brewers Coffee
//Calculate Coffee Averages
using System;
using static System.Console;
namespace Assignment11BrewersCoffee
{
    class CoffeeCalculations
    {
        private static double[] CoffeeSales = new double[4];
        static void Main(string[] args)
        {
            Header();

            UserInput();
            WriteLine("****************************************");

            CoffeeValues();
            WriteLine("****************************************");

            CoffeeValuesEach();
            WriteLine("****************************************");

            WriteLine($"Highest Pounds is {CoffeeMaximum():N1}");
            WriteLine("****************************************");

            CoffeeLowest();
            WriteLine("****************************************");

            ReadLine();
        }
        private static void Header()
        {
            string date = DateTime.Today.ToShortDateString();
            WriteLine("****************************************");
            WriteLine("\tMonthly Pounds Report");
            WriteLine("\tDaniel Simard");
            WriteLine($"\t{date}");
            WriteLine("Enter 4 months of coffee pound sales");
            WriteLine("****************************************");
        }
        private static void UserInput()
        {
            for (int i = 0; i < CoffeeSales.Length; i++)
            {
                double sale = CoffeeMonths($"Enter pounds month {i + 1}: ");
                CoffeeSales[i] = sale;
            }
        }
        private static double CoffeeMonths(string message)
        {
            Write(message);
            while (true)
            {
                string line = ReadLine();
                if (double.TryParse(line, out double value))
                {
                    return value;
                }
                else
                {
                    WriteLine("Incorrect value");
                    Write(message);
                }
            }
        }
        private static void CoffeeValuesEach()
        {
            double avg = 0;
            WriteLine("Display Pounds For Each Loop");
            foreach (double value in CoffeeSales)
            {
                WriteLine($"\t\t{value}");
                avg += value;
            }
            avg /= CoffeeSales.Length;
            WriteLine($"Average Pounds is {avg:N1}");
        }
        private static void CoffeeValues()
        {
            double avg = 0;
            WriteLine("Display Pounds For Loop");
            for (int i = 0; i < CoffeeSales.Length; i++)
            {
                double value = CoffeeSales[i];

                WriteLine($"\t\t{value}");
                avg += value;
            }
            avg /= CoffeeSales.Length;
            WriteLine($"Average Pounds is {avg:N1}");
        }
        private static double CoffeeMaximum()
        {
            double maximum = 0;
            for (int i = 0; i < CoffeeSales.Length; i++)
            {
                if (CoffeeSales[i] > maximum)
                {
                    maximum = CoffeeSales[i];
                }
            }
            return maximum;
        }
        private static void CoffeeLowest()
        {
            double threshold = CoffeeMonths("Find months Lower than: ");
            int count = 0;
            for (int i = 0; i < CoffeeSales.Length; i++)
            {
                if (CoffeeSales[i] < threshold)
                {
                    count++;
                }
            }
            WriteLine($"There are {count} months lower than {threshold:N1}");
        }
    }
}
