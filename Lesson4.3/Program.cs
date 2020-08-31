using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._3
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string text1 = Console.ReadLine();
            
            float f = float.Parse(text);
            float f1 = float.Parse(text1);
            
            bool res = false;

            res = f < f1;
            Console.WriteLine(res);

            res = f > f1;
            Console.WriteLine(res);

            res = f <= f1;
            Console.WriteLine(res);

            res = f >= f1;
            Console.WriteLine(res);

            Console.ReadKey();

        }
    }
}
