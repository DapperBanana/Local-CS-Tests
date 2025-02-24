
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        
        if(num < 0)
        {
            Console.WriteLine("Please enter a non-negative number.");
            return;
        }
        
        int sum = num;
        
        while(sum >= 10)
        {
            sum = CalculateSum(sum);
        }
        
        Console.WriteLine("Sum of digits until single-digit: " + sum);
    }
    
    static int CalculateSum(int number)
    {
        int sum = 0;
        
        while(number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        
        return sum;
    }
}
