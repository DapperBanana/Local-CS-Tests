
using System;

class MainClass {
  public static void Main (string[] args) {
    double a, b, c;

    // Get coefficients from user
    Console.WriteLine("Enter the coefficient a:");
    a = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the coefficient b:");
    b = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Enter the coefficient c:");
    c = Convert.ToDouble(Console.ReadLine());

    double discriminant = b * b - 4 * a * c;
    double root1, root2;

    // Calculate roots based on discriminant
    if(discriminant > 0) {
      root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
      root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
      Console.WriteLine("Root 1: " + root1);
      Console.WriteLine("Root 2: " + root2);
    } else if(discriminant == 0) {
      root1 = -b / (2 * a);
      Console.WriteLine("Root: " + root1);
    } else {
      double realPart = -b / (2 * a);
      double imaginaryPart = Math.Sqrt(-discriminant) / (2 * a);
      Console.WriteLine("Root 1: " + realPart + "+" + imaginaryPart + "i");
      Console.WriteLine("Root 2: " + realPart + "-" + imaginaryPart + "i");
    }
  }
}
