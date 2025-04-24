
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number to check if it is a narcissistic number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if(IsNarcissistic(number))
        {
            Console.WriteLine($"{number} is a narcissistic number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a narcissistic number.");
        }
    }

    static bool IsNarcissistic(int number)
    {
        string numStr = number.ToString();
        int power = numStr.Length;
        int sum = 0;
        
        foreach(char digit in numStr)
        {
            int currentDigit = Convert.ToInt32(digit.ToString());
            sum += (int)Math.Pow(currentDigit, power);
        }

        return sum == number;
    }
}
