using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            IsPrime(num);
        }

        static void IsPrime(long n)
        {
            bool Prime = true;
            if (n<=1)
            {
                Prime = false;
            }
                
            
            for (long i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n%i==0)
                {
                    Prime = false;

                }
                else
                {
                    Prime = true;
                }
            }
            Console.WriteLine(Prime);
        }
    }
}
