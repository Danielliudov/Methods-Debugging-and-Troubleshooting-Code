using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string b = Console.ReadLine();

            if (b == "face")
            {
                Face(a);
            }
            else if (b == "area")
            {
                Area(a);
            }
            else if (b == "volume")
            {
                Volume(a);
            }
            else if (b =="space")
            {
                Space(a);
            }
        }
        static void Area(double a)
        {
            a = Math.Pow(a,2)*6;
            Console.WriteLine("{0:f2}",a);
        }

        static void Volume(double a)
        {
            a = Math.Pow(a,3);
            Console.WriteLine("{0:f2}",a);
        }
        static void Face(double a)
        {
            a = a * Math.Sqrt(2);
            Console.WriteLine("{0:f2}", a);
        }
        static void Space(double a)
        {
            a = a * Math.Sqrt(3);
            Console.WriteLine("{0:f2}", a);
        }
    }
}
