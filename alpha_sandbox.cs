
using System;

class Program
{
    static void Main()
    {
        double radius, height, volume;

        Console.WriteLine("Enter the radius of the cylinder: ");
        radius = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter the height of the cylinder: ");
        height = Convert.ToDouble(Console.ReadLine());

        volume = Math.PI * radius * radius * height;

        Console.WriteLine("The volume of the cylinder is: " + volume);
    }
}
