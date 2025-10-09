
using System;

class PrimeFactorCalculator
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Prime factors of " + number + " are: ");

        while (number % 2 == 0)
        {
            Console.Write(2 + " ");
            number = number / 2;
        }

        for (int i = 3; i <= Math.Sqrt(number); i = i + 2)
        {
            while (number % i == 0)
            {
                Console.Write(i + " ");
                number = number / i;
            }
        }

        if (number > 2)
            Console.Write(number);
    }
}
