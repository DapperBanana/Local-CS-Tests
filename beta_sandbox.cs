
using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a list of numbers separated by spaces:");
        string input = Console.ReadLine();
        
        string[] strNums = input.Split(" ");
        int[] nums = new int[strNums.Length];
        
        for (int i = 0; i < strNums.Length; i++)
        {
            nums[i] = int.Parse(strNums[i]);
        }
        
        Array.Sort(nums);
        
        double median = 0;
        
        if (nums.Length % 2 == 0)
        {
            median = (nums[nums.Length / 2 - 1] + nums[nums.Length / 2]) / 2.0;
        }
        else
        {
            median = nums[nums.Length / 2];
        }
        
        Console.WriteLine("The median of the list is: " + median);
    }
}
