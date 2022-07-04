using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестр_2_Лаба_4
{
    internal class Segment : Figure
    {
        public Segment(double SegmentLength, string Colour) : base(Colour)
        {
            NameOfFigure = "Segment";
            if (SegmentLength < 0)
            {
                throw new Exception("Segment can`t have length < 0");
            }
            else
                this.SegmentLength = SegmentLength;
        }
        public Segment(double SegmentLength)
        {
            NameOfFigure = "Segment";
            if (SegmentLength < 0)
            {
                throw new Exception("Segment can`t have length < 0");
            }
            else
                this.SegmentLength = SegmentLength;
        }
        public Segment() 
        {
            if (SegmentLength < 0)
            {
                throw new Exception("Segment can`t have length < 0");
            }
        }
        public new void GetArea()
        {
            Console.WriteLine($"The {NameOfFigure} doesn`t have area.");
        }
        public new void GetPerimeter()
        {
            Console.WriteLine($"The {NameOfFigure} doesn`t have perimeter.");
        }
        public void GetSegment()
        {
            Console.WriteLine($"Segment is {SegmentLength}");
        }
        public override bool Equals(object? obj)
        {
            if (obj == null)
                return false;
            Segment segment = obj as Segment;
            if (segment == null)
                return false;
            return segment.Colour == this.Colour && segment.SegmentLength == this.SegmentLength;
        }
        public override string ToString()
        {
            return this.Colour + " " + this.NameOfFigure + " is " + this.SegmentLength;
        }
    }
}
