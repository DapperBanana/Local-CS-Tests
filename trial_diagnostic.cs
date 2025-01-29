
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to find its prime factors: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 2; i <= num; i++)
        {
            while (num % i == 0)
            {
                Console.Write(i + " ");
                num = num / i;
            }
        }

        if (num > 2)
            Console.Write(num);
    }
}
