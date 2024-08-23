
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (IsHarshadNumber(num))
        {
            Console.WriteLine($"{num} is a Harshad number.");
        }
        else
        {
            Console.WriteLine($"{num} is not a Harshad number.");
        }
    }

    static bool IsHarshadNumber(int num)
    {
        int sumOfDigits = CalculateSumOfDigits(num);
        if (num % sumOfDigits == 0)
        {
            return true;
        }
        return false;
    }

    static int CalculateSumOfDigits(int num)
    {
        int sum = 0;
        while (num > 0)
        {
            sum += num % 10;
            num = num / 10;
        }
        return sum;
    }
}
