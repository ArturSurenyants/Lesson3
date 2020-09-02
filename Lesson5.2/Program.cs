using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lesson5._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divisible numbers by 2 or 3");
            string number = Console.ReadLine();
            int a = int.Parse(number);

            if (a % 2 == 0 || a % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 2 or 3");
            }
            else 
            {
                Console.WriteLine("The number is not divisible by 2 or 3");
            }
            Console.ReadKey();
        }
    }
}
