
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;
        int tempNumber = number;

        while (tempNumber > 0)
        {
            int digit = tempNumber % 10;
            sum += digit;
            tempNumber = tempNumber / 10;
        }

        Console.WriteLine("Sum of digits in the number {0} is: {1}", number, sum);
    }
}
