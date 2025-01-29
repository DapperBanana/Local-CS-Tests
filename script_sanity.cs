
using System;

class Program
{
    static void Main()
    {
        double radius1, radius2, height;
        
        // Get user input for radius of larger base
        Console.Write("Enter the radius of the larger base of the frustum: ");
        radius1 = Convert.ToDouble(Console.ReadLine());

        // Get user input for radius of smaller base
        Console.Write("Enter the radius of the smaller base of the frustum: ");
        radius2 = Convert.ToDouble(Console.ReadLine());

        // Get user input for height
        Console.Write("Enter the height of the frustum: ");
        height = Convert.ToDouble(Console.ReadLine());

        // Calculate the area of the frustum
        double s = Math.Sqrt((radius1 - radius2)*(radius1 - radius2) + height*height);
        double area = Math.PI * (radius1 + radius2) * (radius1 + radius2 + s);

        // Display the result
        Console.WriteLine($"The area of the frustum of the cone is: {area}");
    }
}
