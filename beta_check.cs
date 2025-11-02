
using System;
using System.Linq;

class Program
{
    public static double CalculateMedian(int[] numbers)
    {
        Array.Sort(numbers);
        
        int n = numbers.Length;
        if (n % 2 == 0)
        {
            return (numbers[n / 2 - 1] + numbers[n / 2]) / 2.0;
        }
        else
        {
            return numbers[n / 2];
        }
    }
    
    static void Main()
    {
        int[] numbers = { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5 };
        
        double median = CalculateMedian(numbers);
        
        Console.WriteLine("Numbers: " + string.Join(", ", numbers));
        Console.WriteLine("Median: " + median);
    }
}
