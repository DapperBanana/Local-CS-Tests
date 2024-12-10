
using System;

class PrimeFactors
{
    public static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());

        Console.Write("Prime factors of " + num + " are: ");

        for (int i = 2; i <= num; i++)
        {
            while (num % i == 0)
            {
                Console.Write(i + " ");
                num = num / i;
            }
        }

        if (num > 2)
        {
            Console.Write(num);
        }
    }
}
