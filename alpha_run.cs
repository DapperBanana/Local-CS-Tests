
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Int32.Parse(Console.ReadLine());

        while (num >= 10)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            num = sum;
        }

        Console.WriteLine("Sum of digits until single digit: " + num);
    }
}
