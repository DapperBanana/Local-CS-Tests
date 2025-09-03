
using System;

class Program
{
    static int SumOfDigits(int num)
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
        int number = Convert.ToInt32(Console.ReadLine());

        int result = SumOfDigits(number);

        Console.WriteLine($"The sum of the digits of {number} is: {result}");
    }
}
