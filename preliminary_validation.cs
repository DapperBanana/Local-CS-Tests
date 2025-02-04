
using System;

class Program
{
    static int CalculateSumOfDigits(int number)
    {
        int sum = 0;
        
        // Loop through each digit in the number and add them to the sum
        while (number > 0)
        {
            sum += number % 10;
            number /= 10;
        }
        
        return sum;
    }
    
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        int sum = CalculateSumOfDigits(number);
        
        Console.WriteLine($"The sum of digits in the number is: {sum}");
    }
}
