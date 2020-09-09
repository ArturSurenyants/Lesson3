using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The first dividible number by 3 in array {A,B}");
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            int A = int.Parse(number1);
            int B = int.Parse(number2);
            for (int i = A; i <= B; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }
            Console.ReadKey();
        }
        
    }
}