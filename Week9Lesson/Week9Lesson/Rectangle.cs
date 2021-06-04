using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week9Lesson
{
    class Rectangle
    {

        //private double width, length;

        // getthers and setters...
        public double Width { get; set; }
        public double Length { get; set; }

        public Rectangle(double width, double length)
        {
            Width = width;
            Length = length;
        }


        public double Area => Width * Length; // Lambda expression 

        //public double getArea(){ return Width * Length; }

        public override string ToString()
        {

            return $"Rectangle => width: {Width}, length: {Length}, Area: {Area}";
        }

    }
}
