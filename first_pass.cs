
using System;

class Program
{
    static bool IsHarshadNumber(int num)
    {
        int sum = 0;
        int temp = num;

        while (temp > 0)
        {
            sum += temp % 10;
            temp /= 10;
        }
        
        return num % sum == 0;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());

        if (IsHarshadNumber(num))
        {
            Console.WriteLine($"{num} is a Harshad (Niven) number.");
        }
        else
        {
            Console.WriteLine($"{num} is not a Harshad (Niven) number.");
        }
    }
}
