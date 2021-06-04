using System;

namespace Week7Lesson
{
    class Program
    {

        // ----> namespace ---> class --> functions
        // first look into classes
        // what is a class in programming language


        // classes are blueprint for objects

        // what is an object

        // object is an instance of a class
        // object has properties

        // object in the real world is a physical entity
        // 1) Name: Monitor
        // 2) Properties: Size
        // 3) Functionality(behaviour): On() Off()

        // ---------------------------------------------------

        // What a difference between b/w real world object and programming language one
        // the objects in programming languages doesnt have to be a physical entity
        /*
         * 

        1) Name: BankAccount
        2) Properties: balance, type, account holder name, bank name
        3) Functionality: WithDraw() Deposit()


        // overload and override a function
         
         */

        public static void Message()
        {
            Console.WriteLine("Hesam");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");



            //non static
            Random rand = new Random();
            rand.Next(1, 100);

        }
    }
}
