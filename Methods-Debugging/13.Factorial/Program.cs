using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Factorial(n);
        }
        static void Factorial(BigInteger n)
        {
            BigInteger num = 1;
            for (BigInteger i = n; i >0; i--)
            {
                num = num*i;

            }
            Console.WriteLine(num);
        }
    }
}
