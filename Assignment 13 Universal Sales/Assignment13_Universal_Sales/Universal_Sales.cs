using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
namespace Assignment13_Universal_Sales
{
    class Universal_Sales
    {
        public void DisplayMonths(string[,] salesArray)
        {
            string str = string.Format("{0,-8}{1,-7}{2,-7}{3,-7}\n", "Names", "Jan(1)", "Feb(2)", "Mar(3)");

            for (int i = 0; i < salesArray.GetLength(0); i++)
            {
                str += string.Format("{0,-8}{1,-7}{2,-7}{3,-7}\n", salesArray[i, 0], salesArray[i, 1], salesArray[i, 2], salesArray[i, 3]);
            }
            WriteLine("***********************************");
            WriteLine(str);
        }
        public void SpecificMonth(string[,] salesArray)
        {
            double sumJanuary = 0;
            double sumFebrurary = 0;
            double sumMarch = 0;
            WriteLine("***********************************");
            Write("Enter sales month (1, 2, or 3): ");
            string find = ReadLine();
            for (int i = 0; i < salesArray.GetLength(0); i++)
            {
                sumJanuary += double.Parse(salesArray[i, 1]);
                sumFebrurary += double.Parse(salesArray[i, 2]);
                sumMarch += double.Parse(salesArray[i, 3]);
            }
            if (find == "1")
            {
                WriteLine($"Total for month: {sumJanuary:C}");
            }
            else if (find == "2")
            {
                WriteLine($"Total for month: {sumFebrurary:C}");
            }
            else if (find == "3")
            {
                WriteLine($"Total for month: {sumMarch:C}");
            }
            else
            {
                WriteLine("Not found");
            }
        }
        public void SpecificPerson(string[,] salesArray)
        {
            string persontofind;
            bool found = false;
            WriteLine("***********************************");
            Write("Enter name: ");
            persontofind = ReadLine();
            double sum;
            int c = 0;
            while (found == false && c < salesArray.GetLength(0))
            {
                if (persontofind.ToUpper() == salesArray[c, 0].ToUpper())
                {
                    found = true;
                }
                else
                    c += 1;
            }
            if (found)
            {
                sum = double.Parse(salesArray[c, 1]) + double.Parse(salesArray[c, 2]) +
                    double.Parse(salesArray[c, 3]);

                WriteLine("Sales for {0} are: {1:C}", persontofind, sum);
            }
            else
            {
                WriteLine("Name not found");
            }
            Read();
        }
    }
}
