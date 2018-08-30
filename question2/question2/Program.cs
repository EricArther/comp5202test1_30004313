using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("this program will calculate the average of your ten numbers.");
            double answer = 0;

            for(int i = 0; i < 10; i++)
            {
                Console.Write("give me a number. ");
                double number = double.Parse(Console.ReadLine());
                answer += number;
            }

            answer /= 10;

            Console.WriteLine($"the average of these ten number is {answer}.");

            Console.ReadKey();
        }
    }
}
