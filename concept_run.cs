
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter two numbers to calculate their GCD:");
        
        // Read the two numbers from the user
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        // Calculate the GCD
        int gcd = CalculateGCD(num1, num2);
        
        // Display the GCD
        Console.WriteLine($"The GCD of {num1} and {num2} is: {gcd}");
    }
    
    static int CalculateGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        
        return a;
    }
}
