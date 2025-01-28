
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        if(IsNarcissistic(number))
        {
            Console.WriteLine($"{number} is a narcissistic number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a narcissistic number.");
        }
    }
    
    static bool IsNarcissistic(int number)
    {
        int numDigits = (int)Math.Floor(Math.Log10(number) + 1);
        int sum = 0;
        int temp = number;
        
        while(temp > 0)
        {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, numDigits);
            temp /= 10;
        }
        
        return sum == number;
    }
}
