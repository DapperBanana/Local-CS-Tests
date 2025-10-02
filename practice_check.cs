
using System;

class Program
{
    public static bool IsVampireNumber(int number)
    {
        string numberStr = number.ToString();
        int digits = numberStr.Length;
        if (digits % 2 != 0)
        {
            return false;
        }

        for (int i = 10; i < 100; i++)
        {
            if (numberStr.Contains(i.ToString()))
            {
                int factor1 = i;
                int factor2 = number / i;
                if (factor1 * factor2 == number)
                {
                    string resultStr = factor1.ToString() + factor2.ToString();
                    char[] resultArray = resultStr.ToCharArray();
                    Array.Sort(resultArray);

                    string numberSorted = String.Concat(numberStr.OrderBy(c => c));

                    if (String.Join("", resultArray) == numberSorted)
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }

    static void Main()
    {
        Console.WriteLine("Enter a number to check if it is a vampire number: ");
        int number = int.Parse(Console.ReadLine());

        if (IsVampireNumber(number))
        {
            Console.WriteLine(number + " is a vampire number.");
        }
        else
        {
            Console.WriteLine(number + " is not a vampire number.");
        }
    }
}
