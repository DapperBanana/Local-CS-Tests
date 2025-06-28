
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine($"Prime factors of {number} are:");
        for (int i = 2; i <= number; i++)
        {
            while (number % i == 0)
            {
                Console.Write(i + " ");
                number = number / i;
            }
        }
    }
}
