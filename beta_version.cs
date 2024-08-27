
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        int sum = CalculateDigitSum(num);

        Console.WriteLine("The sum of the digits until it becomes a single-digit number is: " + sum);
    }

    static int CalculateDigitSum(int n)
    {
        while (n > 9)
        {
            int sum = 0;
            while (n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            n = sum;
        }

        return n;
    }
}
