
using System;

class Program
{
    static int FindGCD(int a, int b)
    {
        return b == 0 ? a : FindGCD(b, a % b);
    }

    static int FindLCM(int a, int b)
    {
        return (a * b) / FindGCD(a, b);
    }

    static int FindLCMOfList(int[] numbers)
    {
        int result = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            result = FindLCM(result, numbers[i]);
        }

        return result;
    }

    static void Main()
    {
        int[] numbers = { 3, 5, 10 };

        int lcm = FindLCMOfList(numbers);

        Console.WriteLine($"LCM of the numbers {string.Join(", ", numbers)} is: {lcm}");
    }
}
