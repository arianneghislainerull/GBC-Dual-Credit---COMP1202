using System;

namespace Week3Lesson
{
    class Program
    {
        static void Main(string[] args)
        {
            // boolean expression in general
            // decision making
            // repetition structures
            // function

            Console.WriteLine("Hello World!");

            bool a = true;
            bool b = false;

            int x = 10;
            int y = 5;
            x += --x; // x = x + x-- ==> outputs 19
            Console.WriteLine(x);

            // arethmatic operation (+ - / %)
            // x > y    x >=    x > y     x <= y   x == y

            // x = y // assigning variable x by value stored in variable 
            int result = x + y;
            Console.WriteLine(result);

            // rational operation --> true or false
            bool result2 = x == y;
            Console.WriteLine(result2);

            
            Console.WriteLine("Press any key to exit!");
            Console.ReadKey();

            // we cannot sometimes make decisions based on one rational operation
            // and we may use multiple rational operation to make decisions

            // AND (&&)
            /* OR (||)
             * NOT (!)
             * 
             */

            // bool res = a && b;

            // bool result2 = x != y;
            // Console.WriteLine(result2); // true

            Console.WriteLine("Enter their age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter their height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            bool resultCompare = age > 20 || height > 180;
            Console.WriteLine(resultCompare);

            // ------------------------
            // utility function = x + y + z


            // -----------------
            // how to make decision in programming...
            // there are 3 structure for decision making in C#
            // 1) single decision structure -------> if statements
            // 2) dual alternative decision structure (if-else)
            // 3) nested decision structure (if-else-then)


            /*
            if (age > 20 && height > 100)
            {
                Console.WriteLine("We have a match!");
            }
            else
            {
                Console.WriteLine("We don't have a match.");
            }
            */

            Console.WriteLine("Enter a number between 0 to 100 and I tell you the range!");
            int number = Convert.ToInt32(Console.ReadLine()); // 57

            // number > 100 || number < 0

            /*if (!(number < 100 && number > 0))
            {
                // Console.WriteLine($"the number {number} is out of range!");

                Console.WriteLine("the number {0} is out of range!", number);


            }*/


            if (number > 100 || number < 60)
            {
                Console.WriteLine("the number is out of range");
            }
            else if (number > 90)
            {
                Console.WriteLine("the range is between 90-100 ");
            }

            else if (number > 80)
            {
                Console.WriteLine("the range is between 80-90");
            }

            else if (number > 70 )
            {
                Console.WriteLine("the range is between 70-80");
            }
            else if (number > 60)
            {
                Console.WriteLine("the range is between 60-70");
            }
            


        }
    }
}
