using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program2
{
    class Program
    {
        static void Main(string[] args)
        {
            //средний
            try
            {
                const double k = 8.2;
                double Y, c, a, x;
                Console.Write("Введите x:");
                x = double.Parse(Console.ReadLine());
                c = Math.Sqrt(Math.Abs(x));
                a = Math.Pow(c, 4) + Math.Pow(k, 3);
                Y = Math.Pow(Math.Log(a), 3) + Math.Pow(Math.Cos(x), 5);
                Console.WriteLine("c =" + c);
                Console.WriteLine("a =" + a);
                Console.WriteLine("Y =" + Y);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadKey();
        }
    }
}