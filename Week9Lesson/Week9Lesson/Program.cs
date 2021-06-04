using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week9Lesson
{
    // inheritance : make a class a base and drived another class from it..
    // aggregation of classes!  ---> you can use one object of a class as a parameter to another class!

    class Program
    {
        static void Main(string[] args)
        {

            Rectangle rec1 = new Rectangle(3, 4);
            Cuboid cub1 = new Cuboid(7, 8, 9);
            Console.WriteLine(rec1);
            Console.WriteLine(cub1);
            Address add1 = new Address(11, "Yonge Street", "Toronto", "M3T 3N6");
            Address add2 = new Address(22, "Bayview Street", "Toronto", "L3T7N1");

            Student std1 = new Student(1, "Hesam Akbari", 87, add1);
            Student std2 = new Student(2, "Lalith", 98, add1);
            Student std3 = new Student(3, "Ahmad", 90, new Address(45, "Jakson Ave", "Thornill", "L3T6N3"));


            Console.WriteLine(add1);

            Console.WriteLine(std1);
            Console.WriteLine(std2);
            Console.WriteLine(std3);


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();

        }
    }
}
