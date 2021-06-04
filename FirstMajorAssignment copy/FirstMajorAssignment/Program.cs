using System;
using System.Linq;

namespace FirstMajorAssignment
{
    class Program
    {
        public const double FixedTheaterExpensePerDay = 15000;
        public static string TheaterName(string theaterName)
        {
            return theaterName;
        }

        public static string TheaterLocation(string theaterLocation)
        {
            return theaterLocation;
        }

        public static double TicketPrice(double theaterPrice)
        {
            return theaterPrice;
        }

        public static int NumMovieScreenings(int theaterScreening)
        {
            return theaterScreening;
        }

        public static double NumOfCustomers(double theaterCustomer)
        {
            return theaterCustomer;
        }

        public static double RevenueEachDay(double theaterCustomer, double theaterPrice)
        {
            return theaterCustomer * theaterPrice;
        }

        public static double ProfitOrLoss(double theaterCustomer, double theaterPrice, double fixedTheaterExpensePerDay)
        {
            return (theaterCustomer * theaterPrice) - fixedTheaterExpensePerDay;
        }

        public static void Main(string[] args)
        {
            Console.Title = "Tabular Report of Theaters in Ontario";
            Console.WriteLine("=============================================================");
            Console.WriteLine("|| 'Welcome to the 'Tabular Report of Theaters in Ontario' ||");
            Console.WriteLine("=============================================================");
            Console.WriteLine();
            Console.WriteLine("Enter the number of theaters: ");
            int numOfTheaters = Convert.ToInt32(Console.ReadLine());
            int count = 1;

            while (count <= numOfTheaters)
            {
                Console.WriteLine("Enter the theater's name: ");
                string theaterName0 = Console.ReadLine();
                string theaterName1 = TheaterName(theaterName0);
                Console.WriteLine();

                Console.WriteLine("Enter the theater's location: ");
                string theaterLocation0 = Console.ReadLine();
                string theaterLocation1 = TheaterLocation(theaterLocation0);
                Console.WriteLine();

                // ticket price
                int z = 0;
                do
                {
                    Console.WriteLine("Enter the ticket price: ");
                    Console.WriteLine("Price must between $9.99 to $19.99");
                    double theaterPrice0 = Convert.ToInt32(Console.ReadLine());
                    if (theaterPrice0 > 9.99 && theaterPrice0 < 19.99)
                        Console.WriteLine();
                        double theaterPrice1 = TicketPrice(theaterPrice0);

                        int i = 1;
                        Console.WriteLine("Enter the number of dates: ");
                        int numOfDates = Convert.ToInt32(Console.ReadLine());
                        while (i <= numOfDates)
                        {
                            // date
                            int a = 0;

                            do
                            {
                                Console.WriteLine("Enter the date in the mm/dd/yyyy format: ");
                                Console.WriteLine("The date must NOT be a FUTURE DATE");
                                string date = Console.ReadLine();
                                DateTime dateParsed = DateTime.Parse(date);
                                Console.WriteLine();
                                var dateToday = DateTime.Today;
                                if (dateToday >= dateParsed)

                                    // number of customers
                                    do
                                    {
                                        Console.WriteLine("Enter the number of customers: ");
                                        Console.WriteLine("At least one customer per day");
                                        double theaterCustomer0 = Convert.ToInt32(Console.ReadLine());
                                        if (theaterCustomer0 > 0)
                                            Console.WriteLine();
                                            double theaterCustomer1 = NumOfCustomers(theaterCustomer0);
                                        
                                            // number of movie screening
                                            do
                                            {
                                                Console.WriteLine("Enter the number of movie screening: ");
                                                Console.WriteLine("At least one movie screening per day");
                                                int theaterScreening0 = Convert.ToInt32(Console.ReadLine());
                                                if (theaterScreening0 > 0)
                                                    Console.WriteLine();
                                                    double theaterScreening1 = NumMovieScreenings(theaterScreening0);
                                                    double revenue = RevenueEachDay(theaterCustomer1, theaterPrice1);
                                                    double profitOrLoss1 = ProfitOrLoss(theaterCustomer1, theaterPrice1, FixedTheaterExpensePerDay);
                                                    Console.WriteLine("====================================================");
                                                    Console.WriteLine("|| Theater Name: {0}                 ", theaterName1 , " ||");
                                                    Console.WriteLine("====================================================");
                                                    Console.WriteLine("|| Theater Location: {0}             ", theaterLocation1, " ||");
                                                    Console.WriteLine("====================================================");
                                                    Console.WriteLine("|| Theater Customer: {0}             ", theaterCustomer1, " ||");
                                                    Console.WriteLine("====================================================");
                                                    Console.WriteLine("|| Ticket Price: {0}                 ", theaterPrice1, " ||");
                                                    Console.WriteLine("====================================================");
                                                    Console.WriteLine("|| Number of Movie Screenings{0}     ", theaterScreening1, " ||");
                                                    Console.WriteLine("====================================================");
                                                    Console.WriteLine("|| Revenue: {0}                      ", revenue, " ||");
                                                    Console.WriteLine("====================================================");
                                                    Console.WriteLine("|| Profit Or Loss: {0}               ", profitOrLoss1, " ||");
                                                    Console.WriteLine("====================================================");
                                                    break;
                                            } while (true);

                                        break;
                                    } while (true);

                            a++;
                            } while (a == 0);

                            i++;
                        }

                    z++;
                } while (z==0);     

                count++;
            }


            Console.WriteLine("Enter the number of theaters: ");
            int numOfTheaters2 = Convert.ToInt32(Console.ReadLine());
            int countXYZ = 1;

            while (countXYZ <= numOfTheaters2)
            {

                Console.WriteLine("Enter the theater's name: ");
                string theaterName2 = Console.ReadLine();
                string theaterName3 = TheaterName(theaterName2);
                Console.WriteLine();


                int[] movieScreeningsArray = new int[12];
                int counter1 = 0;

                Console.WriteLine("Enter the number of movie screenings in each month [Jan to Dec]");

                for (counter1 = 0; counter1 < movieScreeningsArray.Length; counter1++)
                {
                    string input = Console.ReadLine();
                    if (input == "")
                        break;
                    else
                        int.TryParse(input, out movieScreeningsArray[counter1]);
                }

                for (int i = 0; i < counter1;)
                {
                    Console.WriteLine();
                    Console.WriteLine(movieScreeningsArray[i]);
                    i++;
                    Console.WriteLine("is the number of movie screenings for " + i + "th month ");
                }

                int minNumMovieScreenings = movieScreeningsArray.Min();
                int minNumMovieScreeningsMonth = Array.IndexOf(movieScreeningsArray, minNumMovieScreenings);
                int minNumMonth = minNumMovieScreeningsMonth + 1;


                int[] customersArray = new int[12];
                int counter2 = 0;

                Console.WriteLine();
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
                    Console.WriteLine();
                    Console.WriteLine(customersArray[i2]);
                    i2++;
                    Console.WriteLine("is the number of customers for " + i2 + "th month ");
                }

                int minNumCustomers2 = customersArray.Min();
                int minNumCustomersMonth2 = Array.IndexOf(customersArray, minNumCustomers2);
                int minNumMonth2 = minNumCustomersMonth2 + 1;


                int[] highestRevenueArray = new int[12];
                int counter3 = 0;

                Console.WriteLine();
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
                    Console.WriteLine();
                    Console.WriteLine(highestRevenueArray[i3]);
                    i3++;
                    Console.WriteLine("is the revenue for " + i3 + "th month ");
                }

                int maxNumRevenue3 = highestRevenueArray.Max();
                int maxNumMonthRevenue3 = Array.IndexOf(highestRevenueArray, maxNumRevenue3);
                int minNumMonth3 = maxNumMonthRevenue3 + 1;

                Console.WriteLine();
                if (minNumMonth == 1) Console.WriteLine("In the month of January");
                else if (minNumMonth == 2) Console.WriteLine("In the month of February");
                else if (minNumMonth == 3) Console.WriteLine("In the month of March");
                else if (minNumMonth == 4) Console.WriteLine("In the month of April");
                else if (minNumMonth == 5) Console.WriteLine("In the month of May");
                else if (minNumMonth == 6) Console.WriteLine("In the month of June");
                else if (minNumMonth == 7) Console.WriteLine("In the month of July");
                else if (minNumMonth == 8) Console.WriteLine("In the month of August");
                else if (minNumMonth == 9) Console.WriteLine("In the month of September");
                else if (minNumMonth == 10) Console.WriteLine("In the month of October");
                else if (minNumMonth == 11) Console.WriteLine("In the month of November");
                else if (minNumMonth == 12) Console.WriteLine("In the month of December");
                Console.WriteLine("======================================================================================================");
                Console.WriteLine("|| The minimum number of movie screenings for " + theaterName3 + " is " + minNumMovieScreenings + " ||");
                Console.WriteLine("======================================================================================================");

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
                Console.WriteLine("======================================================================================================");
                Console.WriteLine("|| The minimum number of customers for " + theaterName3 + " is " + minNumCustomers2 + " ||");
                Console.WriteLine("======================================================================================================");

                if (minNumMonth3 == 1) Console.WriteLine("|| In the month of January ||");
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
                Console.WriteLine("======================================================================================================");
                Console.WriteLine("|| The highest revenue for " + theaterName3 + " is " + maxNumRevenue3 + " ||");
                Console.WriteLine("======================================================================================================");

                countXYZ++;
            }

            Console.ReadLine();
        }
    }
}
