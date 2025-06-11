
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 4, 6, 8, 10 };

        int result = CalculateLCM(numbers);

        Console.WriteLine($"The LCM of the numbers is: {result}");
    }

    static int CalculateLCM(int[] numbers)
    {
        Array.Sort(numbers);

        int lcm = numbers[numbers.Length - 1];

        while (true)
        {
            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (lcm % numbers[i] == 0)
                {
                    count++;
                }
            }

            if (count == numbers.Length)
            {
                return lcm;
            }

            lcm++;
        }
    }
}
