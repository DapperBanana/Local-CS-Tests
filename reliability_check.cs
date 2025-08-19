
using System;

class Program
{
    static void Main(string[] args)
    {
        int number = 1260; // Example number
        
        if(IsVampireNumber(number))
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
        string numString = number.ToString();
        int numLength = numString.Length;

        if (numLength % 2 != 0) // Check if the number has an even number of digits
            return false;

        int numDigits = numString.Length;
        int halfNumDigits = numDigits / 2;

        for (int i = 1; i < numDigits; i++)
        {
            for (int j = 1; j < numDigits; j++)
            {
                if (i != j)
                {
                    string numi = numString[i].ToString();
                    string numj = numString[j].ToString();

                    if (numj == "0" && i == halfNumDigits) 
                        continue;

                    string vampireString = numString.Replace(numi, "").Replace(numj, "");

                    if (int.Parse(vampireString) * int.Parse(numString) == number)
                    {
                        return true;
                    }
                }
            }
        }
        return false;
    }
}
