
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = { 4, 17, 9, 3, 12, 5 };

        int secondLargest = FindSecondLargest(numbers);

        Console.WriteLine("The second largest element in the list is: {0}", secondLargest);
    }

    static int FindSecondLargest(int[] numbers)
    {
        if (numbers.Length < 2)
        {
            throw new ArgumentException("Input array must have at least 2 elements");
        }

        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int num in numbers)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (num > secondLargest && num != largest)
            {
                secondLargest = num;
            }
        }

        return secondLargest;
    }
}
