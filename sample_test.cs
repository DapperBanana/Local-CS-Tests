
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a list of numbers separated by spaces: ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');

        int[] values = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            values[i] = int.Parse(numbers[i]);
        }

        int lcm = CalculateLCM(values);
        
        Console.WriteLine("The LCM of the given numbers is: " + lcm);
    }

    static int CalculateLCM(int[] values)
    {
        Array.Sort(values);
        
        int lcm = values[values.Length - 1];
        bool found = false;

        while (true)
        {
            found = true;

            for (int i = 0; i < values.Length; i++)
            {
                if (lcm % values[i] != 0)
                {
                    found = false;
                    break;
                }
            }

            if (found)
            {
                break;
            }

            lcm++;
        }

        return lcm;
    }
}
