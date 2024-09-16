
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 4, 6, 8 }; // Change this array to calculate LCM of different numbers

        int lcm = CalculateLCM(numbers);

        Console.WriteLine("The LCM of the numbers is: " + lcm);
    }

    static int CalculateLCM(int[] numbers)
    {
        int lcm = 1;
        int divider = 2;

        while (true)
        {
            int counter = 0;
            bool divisible = false;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == 0)
                {
                    return 0;
                }
                else if (numbers[i] < 0)
                {
                    numbers[i] = Math.Abs(numbers[i]);
                }

                if (numbers[i] == 1)
                {
                    counter++;
                }

                if (numbers[i] % divider == 0)
                {
                    divisible = true;
                    numbers[i] = numbers[i] / divider;
                }
            }

            if (divisible)
            {
                lcm = lcm * divider;
            }
            else
            {
                divider++;
            }

            if (counter == numbers.Length)
            {
                return lcm;
            }
        }
    }
}
