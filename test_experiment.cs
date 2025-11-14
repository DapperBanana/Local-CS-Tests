
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the numbers (separated by space): ");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        
        int[] numArray = new int[numbers.Length];
        
        for (int i = 0; i < numbers.Length; i++)
        {
            numArray[i] = Convert.ToInt32(numbers[i]);
        }
        
        int result = CalculateLCM(numArray);
        
        Console.WriteLine($"The LCM of the numbers is: {result}");
    }
    
    static int CalculateLCM(int[] numbers)
    {
        int lcm = numbers[0];
        
        for (int i = 1; i < numbers.Length; i++)
        {
            lcm = GetLCM(lcm, numbers[i]);
        }
        
        return lcm;
    }
    
    static int GetGCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        
        return a;
    }
    
    static int GetLCM(int a, int b)
    {
        return (a * b) / GetGCD(a, b);
    }
}
