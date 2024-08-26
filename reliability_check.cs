
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        while (number > 9)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            number = sum;
        }

        Console.WriteLine("The sum of the digits until it becomes a single-digit number is: " + number);
    }
}
