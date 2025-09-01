
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of sides of the regular polygon: ");
        int numSides = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the length of each side of the regular polygon: ");
        double sideLength = Convert.ToDouble(Console.ReadLine());
        
        double apothem = sideLength / (2 * Math.Tan(Math.PI / numSides));
        double area = 0.5 * numSides * sideLength * apothem;
        
        Console.WriteLine("The area of the regular polygon is: " + area);
    }
}
