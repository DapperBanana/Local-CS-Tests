
using System;

class Program
{
    static bool IsPerfectDigitalInvariant(int num)
    {
        int sum = 0;
        int product = 1;

        string numStr = num.ToString();

        foreach (char c in numStr)
        {
            int digit = int.Parse(c.ToString());
            sum += digit;
            product *= digit;
        }

        return sum * product == num;
    }

    static void Main()
    {
       Console.WriteLine("Enter a number to check if it is a perfect digital invariant:");
       int num = int.Parse(Console.ReadLine());

       if(IsPerfectDigitalInvariant(num))
       {
           Console.WriteLine($"{num} is a perfect digital invariant.");
       }
       else
       {
           Console.WriteLine($"{num} is not a perfect digital invariant.");
       }
    }
}
