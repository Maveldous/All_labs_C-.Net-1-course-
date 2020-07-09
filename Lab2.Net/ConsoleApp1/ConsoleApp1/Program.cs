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
            Triangle triangle = new Triangle(3, 4, 5, "FT");
            triangle.Results();
            Console.ReadLine();
        }
    }
}
