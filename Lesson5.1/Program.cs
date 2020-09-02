using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter weekdays (1-7)");
            string number = Console.ReadLine();

            switch (number) 
            {
                case "1":
                        Console.WriteLine("Monday");
                        break;
                case "2":
                        Console.WriteLine("Teusday");
                        break;
                case "3":
                        Console.WriteLine("Wednesday");
                        break;
                case "4":
                        Console.WriteLine("Thursday");
                        break;
                case "5":
                        Console.WriteLine("Friday");
                        break;
                case "6":
                        Console.WriteLine("Saterday");
                        break;
                case "7":
                        Console.WriteLine("Sunday");
                        break;
                default:
                        Console.WriteLine("Error");
                        break;
            }
            Console.ReadKey();
        }
    }
}
