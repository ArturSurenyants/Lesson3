using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print all numbers array {A,B}");
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            int A = int.Parse(number1);
            int B = int.Parse(number2);
            for (int i = A; i <= B; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Count of array = {0}", B - A + 1);
            Console.ReadKey();
        }
    }
}
