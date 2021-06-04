using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Week9Lesson
{
    // drived class : base class
    class Cuboid : Rectangle
    {
        public double Height { get; set; }

        public Cuboid(double width, double length, double height) : base(width, length) { Height = height; }

        //Total Surface area = 2 (Length x Breadth + breadth x height + Length x height)
        public double TotalSurfaceArea => 2 * (Length * Width + Width * Height + Length * Height);

        public double Volume => Area * Height;

        public override string ToString()
        {
            //$"Cuboid => Width : {Width}, Length : {Length}, Height: {Height}, Volume {Volume}," +
            // $" Total Surface Area : {TotalSurfaceArea}"
            return $"Cuboid => BASE: {base.ToString()} ||" + $"Height: { Height}, Volume { Volume}," +
            $" Total Surface Area : {TotalSurfaceArea}";
        }
    }
}
