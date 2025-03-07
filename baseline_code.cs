
using System;

namespace AreaOfHeptagon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the side length of the regular heptagon:");
            double sideLength = Convert.ToDouble(Console.ReadLine());

            double apothem = sideLength / (2 * Math.Tan(Math.PI / 7));
            double area = (7 * sideLength * apothem) / 2;

            Console.WriteLine("The area of the regular heptagon is: " + area);
        }
    }
}
