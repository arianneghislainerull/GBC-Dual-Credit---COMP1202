using System;
using System.Linq;

namespace Trial
{
    class Program
    {
        static void Main(string[] args)
        {
            double percent = 0.54;
            bool valid = true;
            int counter = 1;
            if ((percent > 0.50) && (valid == true))
            {
                counter += 2;
                if (valid == true)
                    counter++;
                    
                else if (percent >= 0.50)

                    counter += 3;
                    Console.WriteLine(counter);
            }
            else
                counter++;
                Console.WriteLine(counter);


        }


    }
}
