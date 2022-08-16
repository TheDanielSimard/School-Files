using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3_Sun_Resort_Reservation
{
    class RoomRate
    {
        //Variables
        double total;
        double subTotal;
        double tax;
        double discountAmount;
        int daysStayed;
        string name;
        bool hasDiscount;
        DateTime dateIn;
        DateTime dateOut;
        BedSize bedSelected;

        //CONSTANTS
        const double KING = 200;
        const double QUEEN = 150;
        const double DOUBLE = 100;
        const double TAX = 0.07;
        const double WINTER_RATE = 30; //Add $30 Daily If Winter

        //Properties
        public string Name
        {
            set { name = value; }
        }

        public DateTime DateIn
        {
            set { dateIn = value; }
        }

        public DateTime DateOut
        {
            set
            {
                if (value <= dateIn)
                {
                    throw new Exception("Dates Incorrect");
                }

                dateOut = value;
            }
        }

        public BedSize Bed
        {
            set { bedSelected = value; }
        }

        public bool Discount
        {
            set { hasDiscount = value; }
        }

        public double Tax
        {
            set { tax = value; }
        }

        public double Subtotal
        {
            set { subTotal = value; }
        }

        public override string ToString()
        {
            double dailyRate = GetDailyRate(bedSelected);
            
            double totalDue = GetTotal(dailyRate);

            string str = $"Reservation\r\n";

            str += $"-----------\r\n";
            str += $"Name \t{name}\r\n";
            str += $"Room Size Selection\t{bedSelected}\r\n";
            str += $"{daysStayed} Nights At {dailyRate:C} is {subTotal:C}\r\n";
            str += $"Discount {discountAmount:C}\r\n";
            str += $"Tax Amount {tax:C}\r\n";
            str += $"Total Amount Due {totalDue:C}\r\n";
            str += $"Thank You!\r\n";

            return str;
        }

        public double GetDailyRate(BedSize bedSize)
        {
            double rate = 0;

            switch (bedSelected)
            {
                case BedSize.King:
                    rate = KING;
                    break;

                case BedSize.Queen:
                    rate = QUEEN;
                    break;

                case BedSize.Double:
                    rate =  DOUBLE;
                    break;
            }

            if (dateIn.Month < 5)
            {
                rate += WINTER_RATE;
            }

            return rate;
        }

        public double GetTotal(double dailyRate)
        {
            daysStayed = dateOut.DayOfYear - dateIn.DayOfYear;

            subTotal = dailyRate * daysStayed;

            total = subTotal;

            if (hasDiscount == true)
            {
                total *= 0.9;

                discountAmount = subTotal * 0.1;
            }

            tax = (total * TAX);
            total += (total * TAX);

            return total;
        }
    }
}
