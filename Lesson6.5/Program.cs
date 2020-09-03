using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of even numbers");
            int n = 20, sum = 0;
            for (int i = 2; i <= n; i+=2)
            sum += i;
            Console.WriteLine("Sum is= {0}", sum);

            Console.ReadKey();
        }
    }
}
