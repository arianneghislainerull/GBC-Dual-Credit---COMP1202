using System;
namespace Week9Lesson
{
    class Student
    {

        public int ID { get; set; }
        public string FullName { get; set; }
        public double TotalAverage { get; set; }
        public Address Add { get; set; }
        // aggregation of classes!  ---> you can use one object of a class as a parameter to another class!

        public Student(int iD, string fullName, double totalAverage, Address add)
        {
            ID = iD;
            FullName = fullName;
            TotalAverage = totalAverage;
            Add = add;
        }

        public override string ToString()
        {
            return $"Student=> ID: {ID}, Name: {FullName}, TotalAverage: {TotalAverage}, {Add}";
        }
    }
}
