
using System;

class Program
{
    static void Main()
    {
        double sideLength = 5.0; // length of each side of the pentagon
        double height = 10.0; // height of the prism

        double apothem = sideLength / (2 * Math.Tan(Math.PI / 5)); // apothem of the pentagon
        double perimeter = 5 * sideLength; // perimeter of the pentagon
        double baseArea = (perimeter * apothem) / 2; // area of the base pentagon
        double lateralArea = perimeter * height; // area of the lateral faces
        double totalArea = (2 * baseArea) + lateralArea; // total surface area

        Console.WriteLine("The area of the regular pentagonal prism is: " + totalArea);
    }
}
