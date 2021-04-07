using System;

namespace Week2DualCredit {
    //This is our comment LOL
    //THANK GOD I DID NOT DROP THIS CLASS

    // Logical vs syntax errors 
    // There is a rule that you have to follow when you code on any programming language
    // They are called syntax


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Welcome to Week 3");

            // program that collects 3 integers and calculate the averasge and then show the result
            // to the user
            // add 3 numbers and then divide it by 3

            /* 1) Display "Enter the first digit"
             * 2) Input n1 --> store this
             * 3) Display "Enter the second digit"
             * 4) Input n2 --> store this
             * 5) Display "Enter the third digit"
             * 6) Input n3 --> store this
             * 
             * set result = n1 + n2 + n3 / 3
             * 
             * Display " the average is ", result
            */

            Console.WriteLine("Welcome to the Week 3");
            Console.WriteLine("Average Calculator: ");

            // --- All the inputs and outputs in programming languages are in form of string 
            // we have to convert the string (input)
            // two ways of conversion --> 1) there is a class called convert
            // 2) each variable has a class and each class has a function to convert 

            Console.WriteLine("Enter the first digit"); // prompt
            float n1 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the second digit"); // prompt
            float n2 = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the third digit"); // prompt
            float n3 = Int16.Parse(Console.ReadLine());

            // mathematical operation priorities (BEDMAS)

            float result = (n1 + n2 + n3) / 3;

            Console.WriteLine("The result is {0}", result);

            /*
             * Mathematical Operations
             */

            int a = 5; // its common to update your variables
            a += 1; // a = a + 1
            Console.WriteLine(a);
            a *= 2; // a = 6 * 2
            Console.WriteLine(a);
            Console.WriteLine(a + 1);
            Console.WriteLine(a);

            a %= 13; // 12/11=1
            Console.WriteLine(a);

            // incrementation (adding one) ---- decrementation (sub by one)
            // a = a+1 -> a+=1  --------------- a = a-1 -> a--

            a++;
            a--;

            // post-pre incrementation
            --a;
            ++a; // increment then use

            Console.WriteLine("- - - - - - - - - - - - - - - - - - - - - -");
            Console.WriteLine(a); // a = 12
            Console.WriteLine(a--);
            Console.WriteLine(a); // 11
                            // 11 + 13
            Console.WriteLine(a++ + ++a); // 24
            Console.WriteLine(a); // 13

            /*
             * Boolean Operators
             */



        }
    }
}
