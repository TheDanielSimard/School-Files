//Daniel Simard
//October 20th, 2021
//Assignment 7 - BreakEven
//Calculate Companies Sales and Costs
using System;
using static System.Console;
namespace Assignment7BreakEven
{
    class Program
    {
        static void Main(string[] args)
        {
            Header_and_Instructions();
            WriteLine("*******************************************************************");
            BreakEven calculations = new BreakEven();

            Write("Enter company name: ");
            calculations.CompanyName = ReadLine();

            Write("Enter selling price of product: ");
            calculations.SellingPrice = double.Parse(ReadLine());

            Write("Enter fixed overhead cost: ");
            calculations.OverHead = double.Parse(ReadLine());

            Write("Enter fixed administrative salaries: ");
            calculations.AdministrativeSalaries = double.Parse(ReadLine());

            Write("Enter raw material percent of selling price: ");
            calculations.MaterialCostPercent = double.Parse(ReadLine());

            Write("Enter labor cost percent of selling price: ");
            calculations.LaborCostPercent = double.Parse(ReadLine());

            WriteLine(calculations);      
            Read();
        }
        static void Header_and_Instructions()
        {
        string date = DateTime.Today.ToShortDateString();
            WriteLine("*******************************************************************\n\t" +
                "BreakEven App\n\t" +
                "Calculates breakeven in units and dollars for businesses\n\t" +
                "that are applying for financing.\n\t" +
                "Daniel Simard\n\t" +
               $"{date}");
            WriteLine("*******************************************************************\n" +
                "This program will determine if your company can recieve financing.\n" +
                "You will be asked to enter selling price of a product, fixed\n" +
                "overhead costs, fixed administrative salaries, raw materials\n" +
                "cost percentage, and labor costs percentage.");
        }
    }
}