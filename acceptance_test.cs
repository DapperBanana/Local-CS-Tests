
using System;

class Program
{
    static void Main()
    {
        int number = 18; // Change this number to check if it is a Harshad number

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
        int sum = 0;
        int originalNumber = number;

        while (number > 0)
        {
            int digit = number % 10;
            sum += digit;
            number /= 10;
        }

        if (originalNumber % sum == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
