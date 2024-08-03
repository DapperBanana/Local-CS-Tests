
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int sumOfDigits = CalculateDigitSum(number);

        while (sumOfDigits >= 10)
        {
            sumOfDigits = CalculateDigitSum(sumOfDigits);
        }

        Console.WriteLine("The sum of the digits of the number until it became a single-digit number is: " + sumOfDigits);
    }

    static int CalculateDigitSum(int num)
    {
        int sum = 0;

        while (num != 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return sum;
    }
}
