
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 5, 15, 30 };

        int max = int.MinValue;
        int secondMax = int.MinValue;

        foreach (int number in numbers)
        {
            if (number > max)
            {
                secondMax = max;
                max = number;
            }
            else if (number > secondMax && number != max)
            {
                secondMax = number;
            }
        }

        Console.WriteLine("The second largest element in the list is: " + secondMax);
    }
}
