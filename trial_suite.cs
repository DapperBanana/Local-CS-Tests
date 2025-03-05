
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int sum = 0;
        int temp = num;

        while (temp > 0)
        {
            int digit = temp % 10;
            sum += digit;
            temp /= 10;
        }

        Console.WriteLine($"The sum of digits in {num} is: {sum}");
    }
}
