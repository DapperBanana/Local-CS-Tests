
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int result = SumOfDigits(number);

        Console.WriteLine($"The sum of the digits of the number is: {result}");
    }

    static int SumOfDigits(int num)
    {
        while (num > 9)
        {
            int sum = 0;

            while (num != 0)
            {
                sum += num % 10;
                num = num / 10;
            }

            num = sum;
        }

        return num;
    }
}
