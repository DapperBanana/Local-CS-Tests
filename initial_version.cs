
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 4, 6, 8 };

        int result = CalculateLCM(numbers);
        
        Console.WriteLine($"LCM of the numbers is: {result}");
    }

    static int CalculateLCM(int[] numbers)
    {
        int lcm = 1;
        int divisor = 2;

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
                    numbers[i] = numbers[i] * -1;
                }
                if (numbers[i] == 1)
                {
                    counter++;
                }

                if (numbers[i] % divisor == 0)
                {
                    divisible = true;
                    numbers[i] = numbers[i] / divisor;
                }
            }

            if (divisible)
            {
                lcm = lcm * divisor;
            }
            else
            {
                divisor++;
            }

            if (counter == numbers.Length)
            {
                return lcm;
            }
        }
    }
}
