
using System;

class Program
{
    static bool IsHarshadNumber(int number)
    {
        int sum = 0;
        int temp = number;
        
        while (temp > 0)
        {
            sum += temp % 10;
            temp /= 10;
        }
        
        return number % sum == 0;
    }
    
    static void Main()
    {
        Console.Write("Enter a number: ");
        int input = int.Parse(Console.ReadLine());
        
        if (IsHarshadNumber(input))
        {
            Console.WriteLine($"{input} is a Harshad (Niven) number.");
        }
        else
        {
            Console.WriteLine($"{input} is not a Harshad (Niven) number.");
        }
    }
}
