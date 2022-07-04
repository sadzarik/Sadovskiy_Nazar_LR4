using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Семестр_2_Лаба_4
{
    class MyFigures
    {
        public int Capacity;
        List<Figure> Figures;
        public MyFigures(int Capacity)
        {
            Figures = new List<Figure>(Capacity);
        }
        public MyFigures()
        {
            Figures = new List<Figure>();
        }
        public string Count()
        {
            return Capacity.ToString();
        }
        public void Add(Figure figure)
        {
            Figures.Add(figure);
            Capacity++;
        }

        public void GetMyFigures()
        {
            Figures.Sort();
            foreach (var figure in Figures)
            {
                Console.WriteLine(figure.ToString());
            }
        }
    }
}
