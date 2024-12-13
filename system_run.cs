
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a list of numbers separated by spaces:");
        string input = Console.ReadLine();

        string[] numbers = input.Split(' ');
        int[] arr = new int[numbers.Length];

        for (int i = 0; i < numbers.Length; i++)
        {
            arr[i] = int.Parse(numbers[i]);
        }

        int result = GetLCM(arr);
        Console.WriteLine($"The Least Common Multiple is: {result}");
    }

    static int GetLCM(int[] numbers)
    {
        int lcm = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            lcm = GetLCMOfTwo(lcm, numbers[i]);
        }

        return lcm;
    }

    static int GetLCMOfTwo(int a, int b)
    {
        return a * b / GetGCD(a, b);
    }

    static int GetGCD(int a, int b)
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
