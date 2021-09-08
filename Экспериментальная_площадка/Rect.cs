using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Am
{
    public class Rect
    {
        public int Width;
        public int Height;

        public Rect(int w, int h)
        {
            this.Width = w;
            this.Height = h;
        }

        public int Area()
        {
            return this.Width * this.Height;
        }
    }
    public class UseRect
{
    public static void More()
    {
            Rect r1 = new Rect(4, 7);
            Rect r2 = new Rect(7, 9);


            Console.WriteLine("Площадь прямоугольника r1: " + r1.Area());
            Console.WriteLine("Площадь прямоугольника r2:" + r2.Area());
        }
    }
}



