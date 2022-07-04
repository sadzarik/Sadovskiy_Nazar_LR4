using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестр_2_Лаба_4
{
    internal class Circle : Segment
    {
        public Circle(double SegmentLength, string Colour) : base(SegmentLength, Colour)
        {
            NameOfFigure = "Circle";
            Area = 3.14* SegmentLength * SegmentLength;
            Perimeter = 2 * 3.14 * SegmentLength;
        }
        public Circle(string Colour, double Area)
        {
            NameOfFigure = "Circle";
            this.Area = Area;
            this.Colour = Colour;
            SegmentLength = Math.Sqrt(Area/3.14);
            Perimeter = 2 * 3.14 * SegmentLength;
        }
        public new void GetSegment()
        {
            Console.WriteLine($"Radius of circle is {SegmentLength}");
        }
        public override string ToString()
        {
            return this.Colour + " " + this.NameOfFigure + " has radius "
                + this.SegmentLength + ", has area " + this.Area + " and perimetr " + this.Perimeter;
        }
    }
}
