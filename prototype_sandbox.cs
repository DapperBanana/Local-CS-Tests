
using System;

class Program
{
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

    static int LucasNumber(int n)
    {
        if (n == 0)
        {
            return 2;
        }
        if (n == 1)
        {
            return 1;
        }
        return LucasNumber(n - 1) + LucasNumber(n - 2);
    }

    static bool IsLucasCarmichaelNumber(int num)
    {
        if (!IsPrime(num))
        {
            return false;
        }

        int k = 2;
        while (true)
        {
            int lucasNumber = LucasNumber(k);
            if (lucasNumber % num == 0)
            {
                return true;
            }
            if (lucasNumber > num)
            {
                break;
            }
            k++;
        }
        
        return false;
    }

    static void Main()
    {
        Console.Write("Enter a number to check if it is a Lucas-Carmichael number: ");
        int num = int.Parse(Console.ReadLine());

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
