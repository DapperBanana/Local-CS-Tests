
using System;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideLength, height, apothem, areaBase, areaSides, totalArea;

            Console.WriteLine("Enter the side length of the pentagon: ");
            sideLength = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the pentagonal prism: ");
            height = Convert.ToDouble(Console.ReadLine());

            apothem = sideLength / (2 * Math.Tan(Math.PI / 5));
            areaBase = (5 * sideLength * apothem) / 2;
            areaSides = (5 * sideLength * height);

            totalArea = 2 * areaBase + areaSides;

            Console.WriteLine("The area of the regular pentagonal prism is: " + totalArea);
        }
    }
}
