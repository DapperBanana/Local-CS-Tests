
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 12, 18, 24 };

        int lcm = CalculateLCM(numbers);

        Console.WriteLine("LCM of the numbers is: " + lcm);
    }

    public static int CalculateLCM(int[] numbers)
    {
        int lcm = 1;
        int divisor = 2;

        while (true)
        {
            bool divisible = false;

            int count = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    return 0;
                }

                if (numbers[i] < 0)
                {
                    numbers[i] = Math.Abs(numbers[i]);
                }

                if (numbers[i] == 1)
                {
                    count++;
                }

                if (numbers[i] % divisor == 0)
                {
                    divisible = true;
                    numbers[i] = numbers[i] / divisor;
                }
            }

            if (divisible)
            {
                lcm *= divisor;
            }
            else
            {
                divisor++;
            }

            if (count == numbers.Length)
            {
                return lcm;
            }
        }
    }
}
