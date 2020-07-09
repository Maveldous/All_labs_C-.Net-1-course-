using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Variant 11: Реализовать функцию возведения в квадрат разности двух целых чисел ");
            int frstarg, scndarg;

            Console.WriteLine("Enter first integer number: ");
            frstarg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter second integer number: ");
            scndarg = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Result: " + Math.Pow((frstarg - scndarg), 2));
            Console.ReadLine();
        }
    }
}
