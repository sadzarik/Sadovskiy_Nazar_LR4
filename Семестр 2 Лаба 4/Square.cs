using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестр_2_Лаба_4
{
    class Square : Segment
    {
        public Square(double SegmentLength, string Colour) : base (SegmentLength, Colour)
        {
            NameOfFigure = "Square";
            Area = SegmentLength * SegmentLength;
            Perimeter = 4 * SegmentLength;
        } 
        public Square(string Colour, double Area)
        {
            NameOfFigure = "Square";
            this.Area = Area;
            this.Colour = Colour;
            SegmentLength = Math.Sqrt(Area);
            Perimeter = 4 * SegmentLength;
        }
        public new void GetSegment()
        {
            Console.WriteLine($"Square consists of 4 segments of {SegmentLength}");
        }
        public override string ToString()
        {
            return this.Colour + " " + this.NameOfFigure + " consists of 4 segments of "
                + this.SegmentLength + ", has area " + this.Area + " and perimetr " + this.Perimeter;
        }
    }
}
