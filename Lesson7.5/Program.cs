using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of numbers");
            string number = Console.ReadLine();
            int N = int.Parse(number);
            int sum = 0;
            for (int i = 0; i <= N; i++)
            {
                sum += (N+i)*2;
            }
            Console.WriteLine("Sum is {0}", sum);
            Console.ReadKey();
        }
    }
}
