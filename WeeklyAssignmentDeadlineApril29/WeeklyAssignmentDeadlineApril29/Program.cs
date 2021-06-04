/*

Create a class activity 
- Pick an object around you and create a class out of it [DONE]
-  plan your class (Name, Parameters, Functionality) [DONE]
-  your object has to have at least four parameters at least ( 2 string, two numbers)
-  your class has to have at least two functions besides the constructor
-  create four objects out of that class on your main class and show all the information 


*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeeklyAssignmentDeadlineApril29
{
    class Program
    {
        static void Main(string[] args)
        {
            PencilCase version1 = new PencilCase(1,4,"green","Muji");
            version1.Close();
            Console.WriteLine(version1.info());

            PencilCase version2 = new PencilCase(2, 3, "blue", "Indigo");
            version1.Open();
            Console.WriteLine(version2.info());

            PencilCase version3 = new PencilCase(5, 1, "white", "Walmart");
            version1.Close();
            Console.WriteLine(version3.info());

            PencilCase version4 = new PencilCase(2, 3, "red", "DollarStore");
            version1.Open();
            Console.WriteLine(version4.info());

            Console.WriteLine("press any key to exit");
            Console.ReadKey();
        }
    }
}
