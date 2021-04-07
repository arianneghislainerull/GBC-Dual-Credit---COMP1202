/*

Create the following functions in C# and test them by calling them from your Main() function.

1)	Create a function which has 3 input parameters in a form of integer and return the highest value of those three.
2)	Create a function which has 3 integer parameters and return the lowest value of those three.
3)	Create a function which has 3 integer parameters and return the average of them
4)	Create a function which has 3 integer parameters and return the closest number which is higher than average! 
** hint you already have a function calculate and return the average value


In your main() collect 3 integer as input from the user (console) and pass them to those four function you created and print the result on the console.

 */

using System;

namespace AssignmentOne
{
    class Program
    {


        // start #1

        public static int HighestValue(int num1, int num2, int num3)
        {
            if (num1 > num2 && num1 > num3)
            {
                return num1;
            }
            else if (num2 > num1 && num2 > num3)
            {
                return num2;
            }
            /*
            else if (num3 > num1 && num3 > num2){ return num3;} = else
            */
            else
            {
                return num3;
            }

        }

        // end #1


        // start #2

        public static int LowestValue(int num1, int num2, int num3)
        {
            if (num1 < num2 && num1 < num3)
            {
                return num1;
            }

            else if (num2 < num1 && num2 < num3)
            {
                return num2;
            }
            /* else if (num3 > num1 && num3 > num2){ return num3;} */
            else
            {
                return num3;
            }
        }

        // end #2



        // start #3

        public static int Summation(int num1, int num2, int num3)
        {
            // if you returning something ke keyword is return
            return num1 + num2 + num3;
        }

        public static double Average(int num1, int num2, int num3)
        {
            return Summation(num1, num2, num3) / 3.0;
        }

        // end #3


        // start #4

        public static double ClosestToAndHigherThanAverage(int num1, int num2, int num3)
        {
            //double finalAverage = (int) Average(num1, num2, num3);
            double finalAverage = Average(num1, num2, num3);

            if (num1 > finalAverage && num2 > finalAverage && num3 < finalAverage)
            {
                double diff1 = num1 - finalAverage;
                double diff2 = num2 - finalAverage;

                if (diff2 > diff1)
                {
                    // difference 1 is the closest number that is higher than the average
                    return num1;
                }
                if (diff1 > diff2)
                {
                    return num2;
                }
            }

            else if (num2 > finalAverage && num3 > finalAverage && num1 < finalAverage)
            {
                double diff1 = num2 - finalAverage;
                double diff2 = num3 - finalAverage;

                if (diff2 > diff1)
                {
                    return num2;
                }
                if (diff1 > diff2)
                {
                    return num3;
                }
                
            }

            else if (num3 > finalAverage && num1 > finalAverage && num2 < finalAverage)
            {
                double diff1 = num1 - finalAverage;
                double diff2 = num3 - finalAverage;

                if (diff2 > diff1)
                {
                    // difference 1 is the closest number that is higher than the average
                    return num1;
                }
                if (diff1 > diff2)
                {
                    return num3;
                }
            }

            else if (num1 > finalAverage && num2 > finalAverage && num3 > finalAverage)
            {
                double diff1 = num1 - finalAverage;
                double diff2 = num2 - finalAverage;
                double diff3 = num3 - finalAverage;

                if (diff3 > diff1 && diff2 > diff1)
                {
                    return num1;
                }
                if (diff3 > diff2 && diff1 > diff2)
                {
                    return num2;
                }
                if (diff1 > diff3 && diff2 > diff3)
                {
                    return num3;
                }
            }
            else if (num1 > finalAverage && num2 < finalAverage && num3 < finalAverage)
            {
                return num1;
            }
            else if (num2 > finalAverage && num1 < finalAverage && num3 < finalAverage)
            {
                return num2;
            }
            //(num3 > finalAverage && num1 < finalAverage && num1 < finalAverage)
            else
            {
                return num3;
            }
            return finalAverage;

        }

        // end #4


        static void Main(string[] args)
        {
            Console.WriteLine("This is the second weekly activity c:");

            while (true)
            {
                Console.Write("Enter the value of the first number: ");
                string userFirstString = Console.ReadLine();
                int userFirstNum = int.Parse(userFirstString);

                Console.Write("Enter the value of the second number: ");
                string userSecondString = Console.ReadLine();
                int userSecondNum = int.Parse(userSecondString);

                Console.Write("Enter the value of the third number: ");
                string userThirdString = Console.ReadLine();
                int userThirdNum = int.Parse(userThirdString);

                int highestNum = HighestValue(userFirstNum, userSecondNum, userThirdNum);
                Console.WriteLine("1) The highest number is: {0}", highestNum, "\n");

                int lowestNum = LowestValue(userFirstNum, userSecondNum, userThirdNum);
                Console.WriteLine("2) The lowest number is: {0}", lowestNum, "\n");

                double resultOfAverage = Average(userFirstNum, userSecondNum, userThirdNum);
                Console.WriteLine("3) The average is: {0}", resultOfAverage, "\n");

                double closestAndHigher = ClosestToAndHigherThanAverage(userFirstNum, userSecondNum, userThirdNum);
                Console.WriteLine("4) The number that is closest and higher than average is: {0}", closestAndHigher, "\n");

                Console.WriteLine("\nPress 'k' anytime you want to exit the console application");

                /*
                Console.Write("What do you want to find? Press the number of your choice. \na)Highest Number\nb)Lowest Number\nc)Average\nd)Closest number which is higher than average\n");

                string userChoice = Console.ReadLine();

                if (userChoice == "a" || userChoice == "A")
                {
                    Console.WriteLine("You chose A");
                    int highestNum = HighestValue(userFirstNum, userSecondNum, userThirdNum);
                    Console.WriteLine("1) The highest number is: {0}", highestNum, "\n");
                    Console.WriteLine("");
                }

                else if (userChoice == "b" || userChoice == "B")
                {
                    Console.WriteLine("You chose B");
                    int lowestNum = LowestValue(userFirstNum, userSecondNum, userThirdNum);
                    Console.WriteLine("2) The lowest number is: {0}", lowestNum, "\n");
                    Console.WriteLine("");
                }

                else if (userChoice == "c" || userChoice == "C")
                {
                    Console.WriteLine("You chose C");
                    double resultOfAverage = Average(userFirstNum, userSecondNum, userThirdNum);
                    Console.WriteLine("3) The average is: {0}", resultOfAverage, "\n");
                    Console.WriteLine("");
                }

                else if (userChoice == "d" || userChoice == "D")
                {
                    Console.WriteLine("You chose D");
                    double closestAndHigher = ClosestToAndHigherThanAverage(userFirstNum, userSecondNum, userThirdNum);
                    Console.WriteLine("4) The number that is closest and higher than average is: {0}", closestAndHigher, "\n");
                    Console.WriteLine("");
                }

                else if (userChoice == "k" || userChoice == "K")
                {
                    Environment.Exit(0);
                }
                */
            }
        }
    }
}
