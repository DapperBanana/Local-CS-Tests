
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = CalculateSumOfDigits(number);
        
        Console.WriteLine("The sum of digits in the number is: " + sum);
    }

    static int CalculateSumOfDigits(int number)
    {
        int sum = 0;

        while (number > 0)
        {
            sum += number % 10;
            number = number / 10;
        }

        return sum;
    }
}
