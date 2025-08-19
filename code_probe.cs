
using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter the first number:");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the second number:");
        int num2 = int.Parse(Console.ReadLine());

        int lcm = FindLCM(num1, num2);

        Console.WriteLine($"The Least Common Multiple of {num1} and {num2} is: {lcm}");
    }

    public static int FindLCM(int a, int b)
    {
        return (a * b) / FindGCD(a, b);
    }

    public static int FindGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        
        return a;
    }
}
