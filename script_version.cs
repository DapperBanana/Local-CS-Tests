
using System;

class Program
{
    static void Main()
    {
        double radius, height, volume;

        Console.Write("Enter the radius of the cone: ");
        radius = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the cone: ");
        height = Convert.ToDouble(Console.ReadLine());

        volume = Math.PI * Math.Pow(radius, 2) * height / 3;

        Console.WriteLine($"The volume of the cone is: {volume}");
    }
}
