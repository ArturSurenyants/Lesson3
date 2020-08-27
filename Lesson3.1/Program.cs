using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = 68;
            int n2 = 43;
            int res = 0;

            res = n1 + n2;
            Console.WriteLine(res);

            res = n1 - n2;
            Console.WriteLine(res);

            res = n1 * n2;
            Console.WriteLine(res);

            res = n1 / n2;
            Console.WriteLine(res);

            res = n1 % n2;
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
