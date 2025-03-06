using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Point[] points = new Point[4]
            //{
            //    new Point(2,3),
            //    new Point(-3,4),
            //    new Point(-2,-5),
            //    new Point (2,-5)
            //};

            Point[] points = new Point[4];
            for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine("Введите координаты {0}-й точки", i + 1);
                double x = Convert.ToDouble(Console.ReadLine());
                double y = Convert.ToDouble(Console.ReadLine());
                points[i] = new Point(x,y);
            }






                for (int i = 0; i < points.Length; i++)
            {
                Console.WriteLine(points[i].ToString());

            }






            Console.ReadKey();
        }
    }
}
