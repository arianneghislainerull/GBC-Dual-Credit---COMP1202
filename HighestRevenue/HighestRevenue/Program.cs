using System;
using System.Linq;

namespace HighestRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] highestRevenueArray = new int[12];
            int counter3 = 0;

            Console.WriteLine("Enter the revenue in each month [Jan to Dec]");

            for (counter3 = 0; counter3 < highestRevenueArray.Length; counter3++)
            {
                string input = Console.ReadLine();
                if (input == "")
                    break;
                else
                    int.TryParse(input, out highestRevenueArray[counter3]);
            }

            for (int i3 = 0; i3 < counter3;)
            {
                Console.WriteLine(highestRevenueArray[i3]);

                i3++;
                Console.WriteLine("is the revenue for " + i3 + "th month ");
            }

            int maxNumRevenue3 = highestRevenueArray.Max();
            int maxNumMonthRevenue3 = Array.IndexOf(highestRevenueArray, maxNumRevenue3);
            int minNumMonth3 = maxNumMonthRevenue3 + 1;

            if (minNumMonth3 == 1) Console.WriteLine("In the month of January");
            else if (minNumMonth3 == 2) Console.WriteLine("In the month of February");
            else if (minNumMonth3 == 3) Console.WriteLine("In the month of March");
            else if (minNumMonth3 == 4) Console.WriteLine("In the month of April");
            else if (minNumMonth3 == 5) Console.WriteLine("In the month of May");
            else if (minNumMonth3 == 6) Console.WriteLine("In the month of June");
            else if (minNumMonth3 == 7) Console.WriteLine("In the month of July");
            else if (minNumMonth3 == 8) Console.WriteLine("In the month of August");
            else if (minNumMonth3 == 9) Console.WriteLine("In the month of September");
            else if (minNumMonth3 == 10) Console.WriteLine("In the month of October");
            else if (minNumMonth3 == 11) Console.WriteLine("In the month of November");
            else if (minNumMonth3 == 12) Console.WriteLine("In the month of December");

            Console.WriteLine("The highest revenue for [insert theaterName] is " + maxNumRevenue3);
        }
    }
}
