
using System;

class Program
{
    static void Main()
    {
        int numSides = 9; // Number of sides in a nonagon
        double sideLength = 5.0; // Length of each side
        double apothemLength = 4.3; // Length of apothem

        double area = (numSides * sideLength * apothemLength) / 2;

        Console.WriteLine($"The area of the nonagon is: {area}");
    }
}
