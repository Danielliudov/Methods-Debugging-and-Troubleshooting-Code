using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string Figure = Console.ReadLine();

            if (Figure == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                triangle(a, b);
            }
            else if (Figure == "square")
            {
                double a = double.Parse(Console.ReadLine());
                square(a);
            }
            else if (Figure =="rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                reactangle(a, b);
            }
            else if (Figure == "circle")
            {
                double r = double.Parse(Console.ReadLine());
                circle(r);
            }


        }

        static void triangle (double a,double b)
        {
            double c = a * (b/2);
            Console.WriteLine("{0:f2}", c);
        }

        static void square(double a)
        {
            double c = Math.Pow(a, 2);
            Console.WriteLine("{0:f2}", c);
        }

        static void reactangle(double a,double b)
        {
            double c = a * b;
            Console.WriteLine("{0:f2}",c);
        }

        static void circle(double r)
        {
            double area = Math.PI * (r*r);
            Console.WriteLine("{0:f2}",area);
        }
    }
}
