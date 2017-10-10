using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Master_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (IsPalindrome(i) == true && SumOfDigits(i) == true && ContainsEvenDigit(i) == true)
                {
                    Console.WriteLine(i);
                }
            }
        }

        static bool IsPalindrome(int num)
        {
            string str = num.ToString();
            if (str.Length < 4 && str[0] == str[str.Length - 1])
            {
                return true;
            }
            else if (str.Length < 6 && str[0] == str[str.Length - 1] && str[1] == str[str.Length - 2])
            {
                return true;
            }
            else if (str.Length < 8 && str[0] == str[str.Length - 1] && str[1] == str[str.Length - 2] && str[2] == str[str.Length-3])
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static bool SumOfDigits(int num)
        {
            string str = num.ToString();
            int sumOfstrings = 0;

            for (int i = 0; i <= str.Length-1; i++)
            {
                sumOfstrings = sumOfstrings + int.Parse(str[i].ToString());

            }
            if (sumOfstrings % 7 == 0)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        static bool ContainsEvenDigit(int num)
        {
            int EvenCount = 0;
            string str = num.ToString();
            for (int i = 0; i <= str.Length - 1; i++)
            {
               int EvenNum =  int.Parse(str[i].ToString());
                if (EvenNum%2==0)
                {
                    EvenCount++;
                }
            }
            if (EvenCount>0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
