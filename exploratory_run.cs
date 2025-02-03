
using System;

class Program
{
    static bool IsLucasCarmichaelNumber(int num)
    {
        if (num < 2)
        {
            return false;
        }

        if (num == 2)
        {
            return true;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0 && !IsPrime(i))
            {
                return false;
            }
        }

        return true;
    }

    static bool IsPrime(int num)
    {
        if (num < 2)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number to check if it is a Lucas-Carmichael number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        if (IsLucasCarmichaelNumber(num))
        {
            Console.WriteLine($"{num} is a Lucas-Carmichael number.");
        }
        else
        {
            Console.WriteLine($"{num} is not a Lucas-Carmichael number.");
        }
    }
}
