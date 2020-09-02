using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whether the entered number is natural and odd?");
            string number = Console.ReadLine();
            double a = double.Parse(number);
            if (a < 1 || a % 1 != 0)
            {
                Console.WriteLine("The number is not natural");
            }
            else if (a % 1 == 0 && a % 2 == 1)
            {
                Console.WriteLine("The number is natural & odd");
            }
            else 
            {
                Console.WriteLine("The number is natural & even");
            }
            Console.ReadKey();
        }
    }
}
