using System;

namespace Week4Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            // guessing game
            // we are going to generate a random number between 0 to 100 and ask user to guess it
            // based on what they guess we are doing to give them a hint
            // if they guess something bigger we tell them something smaller and ask again
            // if they guess something bigger we tell them something bigger and ask again
            // until they get the number right!

            // then we tell them how many times took them to guess

            Random rand = new Random(); // we are creating an object out of a class
            int arandNum = rand.Next(1, 100); // next() range of random integer b/w certain numbers
            Console.WriteLine("Guess a number b/w 1 to 100");
            int guess_number = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine(arandNum);

            int count = 1;

            while (guess_number != arandNum)
            {
                if (guess_number > arandNum)
                {
                    Console.WriteLine("Guess the something smaller");
                }
                else {
                    Console.WriteLine("Guess something larger");
                }
                Console.WriteLine("Guess a number b/w 1 to 100");
                guess_number = Convert.ToInt32(Console.ReadLine());

                count++;
            }

            Console.WriteLine("The game is done. It took you"+count+" tries to guess!");
        }
    }
}
