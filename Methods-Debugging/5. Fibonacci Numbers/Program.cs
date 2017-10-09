using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Fibonacci_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Fibonnaci(n);

               
            

        }

        static void Fibonnaci(int n)

        {
            if (n == 0)
            {


                Console.WriteLine("1");
            }
            else
            {


                int a = 0;
                int b = 1;
                int c = 0;

                for (int i = 1; i <= n; i++)
                {
                    c = a + b;

                    a = b;
                    b = c;
                }
                Console.WriteLine(c);
            }
        }
    }
}
