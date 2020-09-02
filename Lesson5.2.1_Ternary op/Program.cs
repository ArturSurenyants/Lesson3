using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._2._1_Ternar_op
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Divisible numbers by 2 or 3 with Ternary operator");
            string number = Console.ReadLine();
            int a = int.Parse(number);

            Console.WriteLine(a % 2 == 0 || a % 3 == 0? "The number is divisible by 2 or 3": "The number is not divisible by 2 or 3");

            Console.ReadKey();
        }
    }
}
