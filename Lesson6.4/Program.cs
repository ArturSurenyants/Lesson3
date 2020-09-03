using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print the power of numbers");

            int n = 2;
            for (int i = 1; i <= 9; i++)
            Console.WriteLine(Math.Pow(n,i));

            Console.ReadKey();
        }
    }
}
