
using System;

class Program
{
    static void Main()
    {
        int number;
        Console.Write("Enter a number: ");
        number = Convert.ToInt32(Console.ReadLine());
        
        int sum = 0;
        while(number > 0)
        {
            sum += number % 10;
            number = number / 10;
        }
        
        Console.WriteLine("The sum of digits in the given number is: " + sum);
    }
}
