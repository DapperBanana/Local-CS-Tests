
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        if (IsVampireNumber(number))
        {
            Console.WriteLine($"{number} is a vampire number.");
        }
        else
        {
            Console.WriteLine($"{number} is not a vampire number.");
        }
    }

    static bool IsVampireNumber(int number)
    {
        string numberString = number.ToString();

        for (int i = 10; i < 100; i++)
        {
            for (int j = 10; j < 100; j++)
            {
                if (i * j == number)
                {
                    string result = (i.ToString() + j.ToString());
                    char[] resultArray = result.ToCharArray();
                    char[] numberArray = numberString.ToCharArray();
                    Array.Sort(resultArray);
                    Array.Sort(numberArray);

                    if (new string(resultArray) == new string(numberArray))
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }
}
