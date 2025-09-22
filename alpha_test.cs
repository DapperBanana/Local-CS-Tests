
using System;

class Program
{
    static void Main()
    {
        int[] numbers = { 4, 6, 8, 10 };
        
        Console.WriteLine("LCM of numbers:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }

        int result = FindLCM(numbers);
        
        Console.WriteLine("\nLCM is: " + result);
    }
    
    static int FindLCM(int[] numbers)
    {
        int lcm = 1;
        bool divisible;
        
        int maxNumber = numbers[0];
        foreach (int number in numbers)
        {
            if (number > maxNumber)
            {
                maxNumber = number;
            }
        }
        
        int currentNumber = 2;
        while (currentNumber <= maxNumber)
        {
            divisible = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % currentNumber == 0)
                {
                    divisible = true;
                    for (int j = 0; j < numbers.Length; j++)
                    {
                        if (numbers[j] % currentNumber == 0)
                        {
                            numbers[j] /= currentNumber;
                        }
                    }
                }
            }
            
            if (divisible)
            {
                lcm *= currentNumber;
            }
            else
            {
                currentNumber++;
            }
        }
        
        return lcm;
    }
}
