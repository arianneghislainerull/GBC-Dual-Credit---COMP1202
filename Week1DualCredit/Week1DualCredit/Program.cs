using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// documentation is important in programing... 
// for single line comments you use two forward slash!

/*   multi line commenting for your code..
 namespace ------> Program -----> Main()

   We dont need to create everything from scratch! there are lots of built-in and
   predefind function that you can use. 

 */

namespace Week1DualCredit
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");
            Console.ReadKey();

            //------------------ inputs-----process---------output-----
            // variables? its a chunk of memory that you hold to keep information
            // temp.
            // --------------- numbers ( digits (int)) , decimals (doubles))
            //-----------------char -------> ASCII tables which a digit asociated
            // to a character http://www.asciitable.com/
            // boolean! => True / False or 1 or 0 , yes no!
            //------------------------------------------------------//
            // strings ---> collection of characters identify with quotations
            // computer does not underestand those
            //  "dasdasdrgt3214323 65^&586"     "Hesam"  "12"
            // if you have an input ( program always collect it in form of strings )
            //-------------------------------
            // memory allocation is really important in C# 

            // variable size and type in C# (integers) : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types

            //===================================== Integers===========================
            sbyte a = -10; // statements 1B of memory storage for your digit
            short b = 234; // 2 Byte of a memory 
            int c = 345465464; // 4 byte of memory
            long d = 34242342342344; // 8 byte

            //================================decimal numbers (doubles)============
            // floating point decimals : https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types
            // syntax error : you are not following the programing language rule!

            float e = 1.2343455F;   // decimals by default known as doubles for making them float
            // floats ( 7 sig digit) you have to force them with suffex F at the end
            double f = 1.22343454556;
            decimal g = 1.23423423452345M;
            // Suffex M makes the number to decimal
            //===========================================================
            bool h1 = true;
            bool h2 = false;
            char i = 'A'; // characters are known to computers using ASCII table! and they identified with
            // single quotation
            string j = "Hesam Akbari"; // quotation is for strings!
            //===========================================================================
            // how to create outputs....
            Console.Write(" a = " + a);// this is write on the same line
            Console.WriteLine("\nb = " + b); //
            // you can also manipulate your string with commands such as \n for new line
            // \t for tab 
            string name;
            // there is two steps in variables 1 - declaring it! 2 - assigning it!
            // ===============================Writing your first program!================================
            // when you dealing with users you have to show them a message ( prompt)
            Console.Write("Tell me your first name : "); // prompt
            // inputs always are in form of string! 
            name = Console.ReadLine(); // I am reading a line from console and store it in the 
            // memory to use it later on!

            Console.WriteLine("Hello {0}, what is your last name?", name);
            // Console.Write("Hello "+name+" What is your last name : ");
            string lastName = Console.ReadLine();
            // rule to nameing a variable ==>
            // there should be no space! ==> two ways to deal with this (camelCase) or _
            // you cannot start with numbers and no special characters neither for naming your variable
            Console.WriteLine("Your full name is {0} {1}.", name, lastName);
            Console.WriteLine("your full name is " + name + " " + lastName);

            Console.WriteLine("Tell me how old are you and I double it!");
            // strings need to be converted to numbers!

            //byte age = Console.ReadLine();
            // Console.WriteLine("your aged is doubled {0}", age * 2);
            Console.WriteLine("Please press any key to exit...");
            Console.ReadKey(); // this prevents for the console to close!


        }
    }
}
