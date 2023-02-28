using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Problem 5 section 3
            const float PI = 3.14f;
            Console.WriteLine(" Enter the raduis ");
            double raduis = double.Parse(Console.ReadLine());
            double area = PI * raduis * raduis;
            Console.WriteLine(" The area equals : " + area);
        }
    }
}
