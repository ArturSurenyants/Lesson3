using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            float f = 25.2f;
            float f3 = f + 22.4f;

            Console.WriteLine(f3);

            float f4 = f - 22.4f;

            Console.WriteLine(f4);

            float f5 = f * 22.4f;

            Console.WriteLine(f5);

            float f6 = f + 22.4f;

            Console.WriteLine(f6);

            Console.ReadKey();
        }
    }
}
