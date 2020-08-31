using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            byte b = Convert.ToByte(text);
            Console.WriteLine(b);

            byte b1 = byte.Parse(text);
            Console.WriteLine(b1);

            int c = Convert.ToInt32(text);
            Console.WriteLine(c);

            int c1 = int.Parse(text);
            Console.WriteLine(c1);

            char d = Convert.ToChar(text);
            Console.WriteLine(d);

            char d1 = char.Parse(text);
            Console.WriteLine(d1);

            float e = Convert.ToSingle(text);
            Console.WriteLine(e);

            float e1 = float.Parse(text);
            Console.WriteLine(e1);

            double f = Convert.ToDouble(text);
            Console.WriteLine(f);

            double f1 = double.Parse(text);
            Console.WriteLine(f1);

            decimal g = Convert.ToDecimal(text);
            Console.WriteLine(d);

            decimal g1 = decimal.Parse(text);
            Console.WriteLine(d1);

            Console.ReadKey();
        }
    }
}
