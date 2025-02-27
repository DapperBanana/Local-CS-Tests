
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the numbers separated by spaces:");
        string input = Console.ReadLine();
        
        string[] numStrings = input.Split(' ');
        double[] nums = Array.ConvertAll(numStrings, double.Parse);
        
        Array.Sort(nums);
        
        double median;
        
        if (nums.Length % 2 == 0)
        {
            int middleIndex1 = nums.Length / 2 - 1;
            int middleIndex2 = nums.Length / 2;
            median = (nums[middleIndex1] + nums[middleIndex2]) / 2;
        }
        else
        {
            int middleIndex = nums.Length / 2;
            median = nums[middleIndex];
        }
        
        Console.WriteLine("The median is: " + median);
    }
}
