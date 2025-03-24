
using System;

class Program
{
    static void Main()
    {
        double sideLength, apothem, height;

        Console.WriteLine("Enter the side length of the pentagon: ");
        sideLength = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the apothem of the pentagon: ");
        apothem = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the prism: ");
        height = Convert.ToDouble(Console.ReadLine());

        double areaBase = 5 * sideLength * apothem;  // area of the pentagon base
        double areaLateral = 5 * sideLength * height;  // lateral area of the prism
        double areaTotal = 2 * areaBase + areaLateral;  // total area of the prism

        Console.WriteLine("The total surface area of the regular pentagonal prism is: " + areaTotal);
    }
}
