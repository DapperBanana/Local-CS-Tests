
using System;

class Program
{
    static int SumOfDigits(int n)
    {
        int sum = 0;

        while (n > 0 || sum > 9)
        {
            if (n == 0)
            {
                n = sum;
                sum = 0;
            }

            sum += n % 10;
            n /= 10;
        }

        return sum;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int result = SumOfDigits(number);

        Console.WriteLine($"The sum of the digits of the number is: {result}");
    }
}
