
using System;

class Program
{
    static void Main()
    {
        int num;
        Console.Write("Enter a number to check if it is a Harshad number: ");
        num = Convert.ToInt32(Console.ReadLine());

        if (IsHarshadNumber(num))
        {
            Console.WriteLine(num + " is a Harshad (Niven) number.");
        }
        else
        {
            Console.WriteLine(num + " is not a Harshad (Niven) number.");
        }
    }

    static bool IsHarshadNumber(int num)
    {
        int sum = 0;
        int originalNum = num;

        while (num > 0)
        {
            sum += num % 10;
            num = num / 10;
        }

        return (originalNum % sum == 0);
    }
}
