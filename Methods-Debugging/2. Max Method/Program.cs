using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Max_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = int.Parse(Console.ReadLine());
            int Num2 = int.Parse(Console.ReadLine());
            int Num3 = int.Parse(Console.ReadLine());

            int FirstMax = GetMax(Num1, Num2);
            int Max = GetMax(FirstMax, Num3);
            Console.WriteLine(Max);
        }


        static int GetMax(int a, int b)
        {
            if (a>b)
            {
                return a;
            }
            else
            {
                return b;
            }
        }
    }
}
