using System;


// namespace --> multi class --> multiple functions

// privacy --> public, protected, private


/*

 private is only available within the class


 protected is available in the class and can be inherited from other classes.


 static because you are using the class official name

 */



namespace Week5Lesson
{
    class Program
    {

        // 1) privacy
        // 2) accessibility
        // 3) return type
        // 4) name of the function
        // 5) input parameters

        // functions can be static or none-static

        // static - means function can directly accessed through its own class
        // none-static - means you need to create an object (instance) out of the class to access them

        public static void getMessage() {

            Console.WriteLine("My name is Hesam");
        }

        static void Main(string[] args)
        {

            // function --> its group of statements designed to do a particular task
            // in order to use a function you have to call it!
            // two kind functions --> built in functions, declared function
            // function has two section
            // 1) header
            // 2) body

            // functions are mini program itself // input --> process --> output
            // header declares all those information


            // reusability of a block of code is one of the most important feature of a function

            Random rand = new Random(); // creating objects out of class Random (instance)
            rand.Next(1, 100);

            // non static
            int[] num = new int[5] { 1, 2, 3, 4, 5 };
            //Console.WriteLine(num.Average());

            Convert.ToBoolean("0");

            Console.WriteLine("Enter the key to exit!");
            Console.ReadKey();

            Console.ReadKey();

            getMessage();

            //Program.getMessage();
            // so writing program is practically an additional information but it doesnt always have to be specified?
        }
    }
}
