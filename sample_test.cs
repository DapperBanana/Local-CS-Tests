
using System;

class Program
{
    static void Main()
    {
        int sideLength = 5;
        int numOfSides = 7;
        
        double area = (numOfSides * Math.Pow(sideLength, 2)) / (4 * Math.Tan(Math.PI / numOfSides));
        
        Console.WriteLine($"The area of a regular heptagon with side length {sideLength} is {area}");
    }
}
