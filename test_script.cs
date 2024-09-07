
using System;

class Program
{
    static void Main()
    {
        double radius;
        
        Console.Write("Enter the radius of the circle: ");
        radius = Convert.ToDouble(Console.ReadLine());

        double area = Math.PI * Math.Pow(radius, 2);

        Console.WriteLine("The area of the circle is: " + area);
    }
}
