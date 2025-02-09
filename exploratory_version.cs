
using System;

class Program
{
    static void Main()
    {
        double radius, area;

        Console.Write("Enter the radius of the circle: ");
        radius = Convert.ToDouble(Console.ReadLine());

        area = Math.PI * radius * radius;

        Console.WriteLine("The area of the circle is: " + area);
    }
}
