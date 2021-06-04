using System;
using System.Linq;

namespace LeastNumberOfCustomers
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] customersArray = new int[12];
            int counter2 = 0;

            Console.WriteLine("Enter the number of customers in each month [Jan to Dec]");

            for (counter2 = 0; counter2 < customersArray.Length; counter2++)
            {
                string input = Console.ReadLine();
                if (input == "")
                    break;
                else
                    int.TryParse(input, out customersArray[counter2]);
            }

            for (int i2 = 0; i2 < counter2;)
            {
                Console.WriteLine(customersArray[i2]);

                i2++;
                Console.WriteLine("is the number of customers for " + i2 + "th month ");
            }

            int minNumCustomers2 = customersArray.Min();
            int minNumCustomersMonth2 = Array.IndexOf(customersArray, minNumCustomers2);
            int minNumMonth2 = minNumCustomersMonth2 + 1;

            if (minNumMonth2 == 1) Console.WriteLine("In the month of January");
            else if (minNumMonth2 == 2) Console.WriteLine("In the month of February");
            else if (minNumMonth2 == 3) Console.WriteLine("In the month of March");
            else if (minNumMonth2 == 4) Console.WriteLine("In the month of April");
            else if (minNumMonth2 == 5) Console.WriteLine("In the month of May");
            else if (minNumMonth2 == 6) Console.WriteLine("In the month of June");
            else if (minNumMonth2 == 7) Console.WriteLine("In the month of July");
            else if (minNumMonth2 == 8) Console.WriteLine("In the month of August");
            else if (minNumMonth2 == 9) Console.WriteLine("In the month of September");
            else if (minNumMonth2 == 10) Console.WriteLine("In the month of October");
            else if (minNumMonth2 == 11) Console.WriteLine("In the month of November");
            else if (minNumMonth2 == 12) Console.WriteLine("In the month of December");

            Console.WriteLine("The minimum number of customers for [insert theaterName] is " + minNumCustomers2);
        }
    }
}
