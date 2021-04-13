using System;

namespace Week6Lesson
{
    class Program
    {

        public static void main_menu()
        {
            Console.WriteLine("============= Main Menu ==============");
            Console.WriteLine(" 1 - Calculator (two numbers)");
            Console.WriteLine(" 2 - Play a game ");
            Console.WriteLine(" 3 - Exit ");
            Console.WriteLine("=====================================");
        }

        public static void sub1_menu()
        {
            Console.WriteLine("============= Main Menu ==============");
            Console.WriteLine(" 1 - Add two numbers");
            Console.WriteLine(" 2 - Subtract two numbers");
            Console.WriteLine(" 3 - Multiple two numbers");
            Console.WriteLine(" 4 - Divide two numbers");
            Console.WriteLine(" 5 - Return to the menu");
            Console.WriteLine("=====================================");
        }

        public static void math_menu()
        {
            while (true)
            {
                sub1_menu(); // show the main menu
                Console.WriteLine("Select one of the menu");
                int select = Convert.ToInt32(Console.ReadLine());

                double result = 0; double a = 0; double b = 0;
                if (select == 1 || select == 2 || select == 3 || select == 4)

                {
                    Console.WriteLine("Enter two numbers in each line");
                    a = Convert.ToDouble(Console.ReadLine());
                    b = Convert.ToDouble(Console.ReadLine());
                }

                

                // double result = 0;

                if (select == 1)
                {
                    //result = a + b;
                    Console.WriteLine($"The result is { a+b }");
                }
                else if (select == 2)
                {
                    //result = a - b;
                    Console.WriteLine($"The result is { a - b}");
                }

                else if (select == 3)
                {
                    //result = a * b;
                    Console.WriteLine($"The result is { a * b}");
                }

                else if (select == 4)
                {
                    //result = a / b;
                    Console.WriteLine($"The result is { a / b}");
                }

                else if (select == 5)
                {
                    break;
                }

                else
                {
                    Console.WriteLine("T");
                }

                Console.WriteLine($"The result is {result}");
            }
        }

        public static void sub2_menu()
        {
            Console.WriteLine("============= Main Menu ==============");
            Console.WriteLine(" 1 - Single Player");
            Console.WriteLine(" 2 - Multiplayer");
            Console.WriteLine(" 3 - Return to the main menu");
            Console.WriteLine("=====================================");
        }

        public static void game_menu()
        {
            while (true)
            {
                //sub2_menu
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
             1) menu driven programming
             2) input validation and exception handling

             */

            while (true)
            {
                main_menu(); // show the main menu
                Console.WriteLine("Select one of the menu");
                int select = Convert.ToInt32(Console.ReadLine());

                if (select == 1)
                {
                    Console.WriteLine("Option 1 is selected");
                    // math menu
                    math_menu();
                }
                else if (select == 2)
                {
                    Console.WriteLine("Option 2 is selected");
                    // game menu
                    game_menu();
                }
                else if (select == 3)
                {
                    Console.WriteLine("Option 3 is selected");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input");
                }
            }
        }
    }
}
