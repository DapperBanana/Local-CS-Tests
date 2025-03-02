
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsHarshadNumber(number))
        {
            Console.WriteLine($"{number} is a Harshad (Niven) number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a Harshad (Niven) number.");
        }
    }

    static bool IsHarshadNumber(int number)
    {
        int sumOfDigits = 0;
        int temp = number;

        while (temp > 0)
        {
            sumOfDigits += temp % 10;
            temp /= 10;
        }

        return number % sumOfDigits == 0;
    }
}
