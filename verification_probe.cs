
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int sum = 0;
        int temp = number;

        while (temp != 0)
        {
            sum += temp % 10;
            temp = temp / 10;
        }

        Console.WriteLine($"The sum of digits in the number {number} is {sum}");
    }
}
