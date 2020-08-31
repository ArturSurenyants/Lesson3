using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int b = int.Parse(text);
            int res = b * 2;
            int res1 = b * b;


            Console.WriteLine(res);
            Console.WriteLine(res1);
            Console.ReadKey();
        }
    }
}
