using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестр_2_Лаба_4
{
    abstract class Figure : IComparable
    {
        public double SegmentLength;
        public double Area;
        public double Perimeter;
        public string NameOfFigure;
        public string Colour;
        public Figure() { }
        public Figure (string Colour)
        {
            this.Colour = Colour;
        }
        public void GetColour()
        {
            Console.WriteLine($"The colour of {NameOfFigure} is {Colour}.");
        }
        public void GetArea()
        {
            Console.WriteLine($"The area of {NameOfFigure} is {Area}.");
        }
        public void GetPerimeter()
        {
            Console.WriteLine($"The perimeter of {NameOfFigure} is {Perimeter}.");
        }
        public int CompareTo(object obj)
        {
            Figure f = obj as Figure;
            if (f != null)
            {
                if (string.Compare(this.NameOfFigure, f.NameOfFigure) < 0)
                    return -1;
                else if (string.Compare(this.NameOfFigure, f.NameOfFigure) > 0)
                    return 1;
                else
                    return 0;
            }
            else
                throw new Exception("Wrong Datatype");
        }
    }
}
