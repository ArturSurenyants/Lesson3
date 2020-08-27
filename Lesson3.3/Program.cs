using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            byte n1 = 72;
            byte n2 = n1;

            int n3 = 260;
            checked
            {
               unchecked
                {
                    byte n4 = (byte)n3;

                    Console.WriteLine(n4);
                }
            }

            Console.ReadKey();
        }
    }
}
