
using System;

class Program
{
    static int CalculateSumOfDigits(int num)
    {
        int sum = 0;
        
        while (num > 0 || sum > 9)
        {
            if (num == 0)
            {
                num = sum;
                sum = 0;
            }
            
            sum += num % 10;
            num /= 10;
        }

        return sum;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int result = CalculateSumOfDigits(number);

        Console.WriteLine("The sum of digits until it becomes a single-digit number is: " + result);
    }
}
