
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the side length of the pentagon:");
        double sideLength = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the height of the prism:");
        double height = Convert.ToDouble(Console.ReadLine());

        double area = 5 * sideLength * sideLength + 10 * sideLength * height;
        Console.WriteLine("The area of the pentagonal prism is: " + area);
    }
}
