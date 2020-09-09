using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of numbers");
            string number = Console.ReadLine();
            double N = double.Parse(number);
            double sum = 0;
            for (double i = 1; i <= N; i++)
            {
                sum += 1 / i;
            }
            Console.WriteLine("Sum is {0}",sum);
            Console.ReadKey();
        }
    }
}
