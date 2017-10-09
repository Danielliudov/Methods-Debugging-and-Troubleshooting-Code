using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsolePrint();
        }
        static void ConsolePrint()
        {
            String name = Console.ReadLine();
            Console.WriteLine("Hello, {0}!",name);
        }

    }
}
