using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print four-digit number");
            string number = Console.ReadLine();
            int b = int.Parse(number);

            int res = b/1000 + b % 1000/100 + b % 100 / 10 + b % 10;
            Console.WriteLine("Sum is= {0}", res);
            Console.ReadKey();
        }
    }
}
