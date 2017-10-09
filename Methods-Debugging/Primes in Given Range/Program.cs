using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Primes_in_Given_Range
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            List<int> list =printPrime(a, b);
            Console.WriteLine(String.Join(", ",list));
        }
        static List<int> printPrime(int a, int b)
        {
            List<int> list = new List<int>();
            bool Prime = true;
            if (a < 2)
            {
                a = 2;
            }
            for (int i = a; i <= b; i++)
            {
                for (int d = 2; d <= Math.Sqrt(i); d++)
                {
                    if (i % d == 0)
                    {
                        Prime = false;
                        break;
                    }
                    else
                    {
                        Prime = true;
                    }
                }
                if (Prime)
                {
                    list.Add(i);
                }
            }
            return list;
        }

    }
}
