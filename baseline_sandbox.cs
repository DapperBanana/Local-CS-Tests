
using System;

class Program
{
    // Function to check if a number is a Harshad (Niven) number
    static bool IsHarshadNumber(int num)
    {
        int sum = 0;
        int originalNum = num;

        // Calculate sum of digits
        while (num > 0)
        {
            sum += num % 10;
            num /= 10;
        }

        // Check if number is divisible by sum of its digits
        return originalNum % sum == 0;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (IsHarshadNumber(number))
        {
            Console.WriteLine(number + " is a Harshad (Niven) number.");
        }
        else
        {
            Console.WriteLine(number + " is not a Harshad (Niven) number.");
        }
    }
}
