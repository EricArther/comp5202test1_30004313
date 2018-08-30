using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this program will tell if your number is even or odd.");
            Console.Write("give me a number between 1 and 1000. ");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0) Console.WriteLine($"{number} is even.");
            else Console.WriteLine($"{number} is odd.");

            Console.ReadKey();
        }
    }
}
