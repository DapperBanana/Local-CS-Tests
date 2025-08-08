
using System;

class Program
{
    static int SumOfDigits(int num)
    {
        int sum = 0;
        
        while (num > 0)
        {
            sum += num % 10;
            num = num / 10;
        }
        
        return sum;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        int sum = number;
        
        while (sum >= 10)
        {
            sum = SumOfDigits(sum);
        }
        
        Console.WriteLine($"The sum of the digits until it becomes a single-digit number is: {sum}");
    }
}
