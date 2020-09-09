using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum numbers array {A,B}");
            string number1 = Console.ReadLine();
            string number2 = Console.ReadLine();
            int A = int.Parse(number1);
            int B = int.Parse(number2);
            int sum = 0;
            for (int i = A; i <= B; i++)
            {
                sum += i;
            }
                Console.WriteLine("Sum is = {0}", sum);
            
            Console.ReadKey();
        }
    }
}
