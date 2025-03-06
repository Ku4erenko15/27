using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Point
    {
        private double x;
        private double y;

        public double X
            {
            get { return x; }
            set { x = value; }
            }
        public double Y
        {
            get { return y; }
            set {  y = value; }
        }

        public Point() {}
        public Point(double x, double y)
        {
            this.X = x;
                this.Y = y;
        }

        //public static void Write(Point p1, Point p2, Point p3, Point p4)
        //{
        //    Console.WriteLine($"Point 1: ({p1.X}, {p1.Y}), Point 2: ({p2.X}, {p2.Y}, Point 3({p3.X},{p3.Y}), Point 4: ({p4.X},{p4.Y}))");
        //}

        public override string ToString()
        {
            return $"X={X}\tY={Y}";
        }


    }
}
