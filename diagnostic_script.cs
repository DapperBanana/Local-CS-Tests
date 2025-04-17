
using System;

class Program
{
    public static bool IsPrime(int num)
    {
        if (num <= 1) return false;
        if (num <= 3) return true;

        if (num % 2 == 0 || num % 3 == 0) return false;

        for (int i = 5; i * i <= num; i += 6)
        {
            if (num % i == 0 || num % (i + 2) == 0)
            {
                return false;
            }
        }

        return true;
    }

    public static bool IsLucasCarmichael(int num)
    {
        if (IsPrime(num)) return false;

        for (int i = 2; i < num; i++)
        {
            if (num % i == 0 && IsPrime(i) && (i - 1) % (num - 1) != 0)
            {
                return false;
            }
        }

        return true;
    }

    static void Main()
    {
        Console.Write("Enter a number to check if it's a Lucas-Carmichael number: ");
        int num = int.Parse(Console.ReadLine());

        if (IsLucasCarmichael(num))
        {
            Console.WriteLine($"{num} is a Lucas-Carmichael number.");
        }
        else
        {
            Console.WriteLine($"{num} is not a Lucas-Carmichael number.");
        }
    }
}
