
using System;

class PrimeFactors
{
    public static void Main()
    {
        Console.Write("Enter a number to find its prime factors: ");
        int number = int.Parse(Console.ReadLine());

        Console.Write("Prime factors of " + number + " are: ");
        FindPrimeFactors(number);
    }

    public static void FindPrimeFactors(int num)
    {
        for (int i = 2; i <= num; i++)
        {
            while (num % i == 0)
            {
                Console.Write(i + " ");
                num = num / i;
            }
        }
    }
}
