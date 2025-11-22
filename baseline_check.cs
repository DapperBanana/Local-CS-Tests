
using System;

class Program
{
   // Function to check if a number is a vampire number
   static bool IsVampireNumber(int num)
   {
       string strNum = num.ToString();
       int numLength = strNum.Length;

       // Check if the number has an even number of digits
       if (numLength % 2 != 0)
       {
           return false;
       }

       // Generate all possible permutations of the number
       for (int i = 10; i <= 99; i++)
       {
           for (int j = i; j <= 99; j++)
           {
               // Check if the product of i and j is equal to the original number
               if (i * j == num)
               {
                   string strI = i.ToString();
                   string strJ = j.ToString();

                   // Check if the factor pairs have the same digits as the original number
                   char[] originalDigits = strNum.ToCharArray();
                   char[] factorDigits = (strI + strJ).ToCharArray();

                   Array.Sort(originalDigits);
                   Array.Sort(factorDigits);

                    // Check if the factor pairs have the same digits as the original number
                   if (new string(originalDigits) == new string(factorDigits))
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
       int number = 1260;

       if (IsVampireNumber(number))
       {
           Console.WriteLine($"{number} is a vampire number.");
       }
       else
       {
           Console.WriteLine($"{number} is not a vampire number.");
       }
   }
}
