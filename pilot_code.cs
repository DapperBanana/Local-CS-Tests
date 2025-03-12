
using System;

class Program
{
    static int CalculateGCD(int num1, int num2)
    {
        while (num2 != 0)
        {
            int temp = num2;
            num2 = num1 % num2;
            num1 = temp;
        }

        return num1;
    }
    
    static void Main()
    {
        Console.WriteLine("Enter two numbers to calculate their GCD:");
        
        Console.Write("Enter the first number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Enter the second number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        int gcd = CalculateGCD(num1, num2);
        
        Console.WriteLine($"The GCD of {num1} and {num2} is: {gcd}");
    }
}
