using System;

namespace FirstWeeklyActivityArianne
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             • The program should ask for the student’s name.
             • The program should ask for Weekly activities, Assignment 1, Assignment 2, Midterm and Final
               exam marks respectively out of 100.
             • Then program should calculate the overall mark of the course out of 100%
             • Show the name of the student along with their total marks and any necessary information you
                see fit!
             • Name your variable properly and comment your code clearly.
             */

            Console.WriteLine("======= Mark Calculator =======");

            Console.Write("Enter the student's name: ");
            string studentName = Console.ReadLine();
            Console.WriteLine("Student name is : " + studentName);

            // Ask for marks
            Console.Write("Enter the mark for weekly activities: ");
            int weeklyActivitiesMark = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the mark for assignment one: ");
            int assignmentOneMark = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the mark for assignment two: ");
            int assignmentTwoMark = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the mark for midterm: ");
            int midtermMark = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the mark for exam: ");
            int examMark = Convert.ToInt32(Console.ReadLine());

            // Total Mark = WeeklyActivity * 10% + Assignment 1*20% + Assignment 2*20% +
            // Midterm * 20 % +final * 30 %

            Console.WriteLine("======= Calculating the Final Mark =======");

            float totalMark = (int) weeklyActivitiesMark * 0.1F + assignmentOneMark * 0.2F +
                assignmentTwoMark * 0.2F + midtermMark * 0.2F + examMark * 0.3F;

            Console.WriteLine("{0}'s final mark is {1}", studentName, totalMark);
        }
    }
}


