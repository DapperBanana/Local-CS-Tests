
using System;

class Program
{
    public static int CalculateDigitSum(int num)
    {
        int sum = 0;

        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        return sum;
    }

    public static int ReduceToSingleDigit(int num)
    {
        while (num >= 10)
        {
            num = CalculateDigitSum(num);
        }

        return num;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int result = ReduceToSingleDigit(number);

        Console.WriteLine($"The sum of the digits of {number} is: {result}");
    }
}
