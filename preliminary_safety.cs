
using System;

class Program
{
    static bool IsPrime(int num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
            {
                return false;
            }
        }
        return true;
    }

    static bool IsLucasCarmichael(int num)
    {
        if (IsPrime(num))
        {
            return false;
        }

        for(int i = 2; i <= num; i++)
        {
            if (num % i == 0)
            {
                if (IsPrime(i) && (i - 1) % (num - 1) != 0)
                {
                    return false;
                }
            }
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number to check if it is a Lucas-Carmichael number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsLucasCarmichael(number))
        {
            Console.WriteLine($"{number} is a Lucas-Carmichael number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a Lucas-Carmichael number.");
        }
    }
}
