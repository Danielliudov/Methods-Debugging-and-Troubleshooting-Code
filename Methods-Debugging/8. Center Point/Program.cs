﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8.Center_Podouble
{
    class Program
    {
        static void Main(string[] args)
        {
           

            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());


            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            Distance(x1,y1,x2,y2);
        }

        static void Distance(double x1,double y1,double x2,double y2)
        {
            double distance1 = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1, 2));
            double distance2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));


            if (distance1 < distance2)
            {
                Console.WriteLine("({0}, {1})", x1, y1);
            }
            else
            {
                Console.WriteLine("({0}, {1})", x2, y2);
            }
        }
    }
    
}
