using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whether the entered number is natural and odd?");
            string number = Console.ReadLine();
            double a = double.Parse(number);

            Console.WriteLine(a < 1 || a % 1 != 0 ? "The number is not natural" : "The number is natural & odd");

            Console.ReadKey();
        }
    }
}
