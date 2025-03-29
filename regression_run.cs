
using System;

class Program
{
    static void Main()
    {
        double sideLength, height;

        Console.WriteLine("Enter the side length of the pentagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the prism: ");
        height = Convert.ToDouble(Console.ReadLine());

        double areaSide = 0.25 * Math.Sqrt(5 * (5 + 2 * Math.Sqrt(5))) * sideLength * sideLength;
        double areaBase = 5 * sideLength * height;
        double totalArea = 2 * areaSide + areaBase;

        Console.WriteLine("The area of the regular pentagonal prism is: " + totalArea);
    }
}
