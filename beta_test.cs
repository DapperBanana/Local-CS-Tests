
using System;

class Program
{
    static bool IsCarmichaelNumber(int num)
    {
        if (num < 2)
        {
            return false;
        }

        if (num == 2 || num == 3 || num == 5 || num == 7)
        {
            return false;
        }

        for (int a = 2; a < num; a++)
        {
            if (GCD(a, num) == 1 && BigInteger.ModPow(a, num - 1, num) != 1)
            {
                return false;
            }
        }

        return true;
    }

    static int GCD(int a, int b)
    {
        if (b == 0)
        {
            return a;
        }

        return GCD(b, a % b);
    }

    static void Main()
    {
        Console.Write("Enter a number to check if it is a Carmichael number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsCarmichaelNumber(number))
        {
            Console.WriteLine($"{number} is a Carmichael number");
        }
        else
        {
            Console.WriteLine($"{number} is not a Carmichael number");
        }
    }
}
