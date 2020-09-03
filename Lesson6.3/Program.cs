using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print numbers less or equal than n");

            int n = 8;
            for (int i = 1; i <= n; i++)
            Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
