
using System;

class Program
{
    static void Main()
    {
        double apothem, sideLength, perimeter, area;

        Console.WriteLine("Enter the apothem length of the pentagon:");
        apothem = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter the side length of the pentagon:");
        sideLength = double.Parse(Console.ReadLine());

        perimeter = 5 * sideLength;
        area = 5.0 / 2.0 * apothem * perimeter + 5 * Math.Pow(sideLength, 2);

        Console.WriteLine("The area of the regular pentagonal prism is: " + area);
    }
}
