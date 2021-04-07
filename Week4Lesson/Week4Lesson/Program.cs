using System;

namespace Week4Lesson
{
    class Program
    {
        static void Main(string[] args)
        {

            // Collection of same type variables in sequence
            // Introduction to arrays ---> memory allocation of same type sequenced data
            // repetition structures --->
            // arrays are objects!

            int [] marks = new int[5] { 40, 50, 60, 70, 80 }; // declaration of an array 
            // int mark2 = 100;

            // index is always size - 1 
            // array of numbers will be filled with zero by default
            // [0,0,0,0,7]
            marks[4] = 7;

            string[] studentNames = new string[5];
            Console.WriteLine(marks[0]);

            Console.WriteLine(studentNames[0]);
            Console.WriteLine(marks);

            Console.WriteLine("Hello World!");
            Console.ReadKey();

            // index = size - 1


            /**
             * In programming tasks are redundant! there are repetition structures 
             * that help us achieve a particular task.
             * 
             * How many type of repetition structures we have?
             * 1) count control (you know how many times you like to repeat something)
             * - for loop, for each 
             * 
             * 2) condition control (you dont know how many times you repeat something)
             * while loop, do-while loop
             * 
             * while loop repeat your statements while the condition is true
             * if the condition is not updates it will run forever
             * while loop minimum iteration: 0 
             * maximum iteration is infinite
             * 
             * do-while minimum iteration: 1
             * maximum iteration is infinite
             * 
             * difference b/w while loop and do while is do while at least will run once 
             * ***/

            int x = 10;
            int y = 20;

          
            while (x<y)
            {
                Console.WriteLine($"{y} is greater than {x}");
                x++;
            }

            Console.WriteLine("======");
            x = 10;
            y = 20;

            do
            {
                Console.WriteLine($"{y} is greater than {x}");
                x++;
            }
            while (x < y);

            // prints nothing because x was never greater than y in the first  place

            // initialize a variable; condition; update

            // preincrement ++2

            int[] numbers = new int[10] { 87, 65, 65, 76, 77,54, 56, 78, 99, 44 };
            // find the average of all these numbers

            int sum = 0;

            for (int i = 0; i < 10; i+=2)


            {
                Console.WriteLine($"numbers [{i}] = {numbers[i]}");
                sum += numbers[i];

               //onsole.WriteLine($"Hesam{i}");
            }

            Console.WriteLine($"The sum is : {sum} ");

        }
    }
}
