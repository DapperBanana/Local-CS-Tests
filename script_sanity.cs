
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a positive integer: ");
        int num = int.Parse(Console.ReadLine());

        Console.Write("Prime factors of " + num + " are: ");

        for (int i = 2; i <= num; i++)
        {
            while (num % i == 0)
            {
                Console.Write(i + " ");
                num = num / i;
            }
        }

        if (num > 1)
        {
            Console.Write(num);
        }
    }
}
