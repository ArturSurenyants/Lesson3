using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Print the number K(7) N(5) times");
            
            int K = 7;
            int N = 5;
            for (int i = 1; i <= N; i++)
            Console.WriteLine(K);

            Console.ReadKey();
        }
    }
}
