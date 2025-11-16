
using System;

class GCDCalculator
{
    static void Main()
    {
        Console.WriteLine("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());
        
        int result = CalculateGCD(number1, number2);
        
        Console.WriteLine("The Greatest Common Divisor of " + number1 + " and " + number2 + " is: " + result);
    }
    
    static int CalculateGCD(int a, int b)
    {
        while(b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        
        return a;
    }
}
