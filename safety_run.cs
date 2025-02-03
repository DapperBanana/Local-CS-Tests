
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the limit for Fibonacci numbers: ");
        int limit = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int num1 = 1;
        int num2 = 2;

        while (num2 <= limit)
        {
            if (num2 % 2 == 0)
            {
                sum += num2;
            }

            // calculate the next Fibonacci number
            int temp = num1 + num2;
            num1 = num2;
            num2 = temp;
        }

        Console.WriteLine("The sum of all even Fibonacci numbers up to {0} is: {1}", limit, sum);
    }
}
