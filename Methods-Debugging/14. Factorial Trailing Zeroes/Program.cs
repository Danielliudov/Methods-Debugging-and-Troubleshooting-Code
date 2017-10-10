using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _14.Factorial_Trailing_Zeroes
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(TrailingZeros(Factorial(n)));
        }
        static BigInteger Factorial(int n)
        {
            BigInteger num = 1;
            for (BigInteger i = n; i > 0; i--)
            {
                num = num * i;

            }
            return num;
        }
        static int TrailingZeros(BigInteger n)
        {
            string str = n.ToString();
            int Count = 0;
            for (int i = str.Length-1; i >= 0; i--)
            {
                if (str[i]=='0')
                {
                    Count++;
                }
                else
                {
                    break;
                }
            }
            return Count;
        }
    }
}
