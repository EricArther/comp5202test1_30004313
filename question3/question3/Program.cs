using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this program will expand a basic quadratic equation.");
            Console.WriteLine("(x + n)(x + m)");

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("m = ");
            int m = int.Parse(Console.ReadLine());

            string b;
            if ((n + m) > 0) b = $"+{n + m}";
            else b = $"{n + m}";

            string c;
            if ((n * m) > 0) c = $"+{n * m}";
            else c = $"{n * m}";


            Console.WriteLine();
            Console.WriteLine($"x^2 {b}x {c}");

            Console.ReadKey();
        }
    }
}
