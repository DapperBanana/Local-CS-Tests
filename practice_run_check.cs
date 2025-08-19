
using System;

namespace NumberBaseConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to convert:");
            string number = Console.ReadLine();

            Console.WriteLine("Enter the base of the input number:");
            int inputBase = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the base to convert to:");
            int targetBase = int.Parse(Console.ReadLine());

            int decimalNumber = ConvertToDecimal(number, inputBase);

            string result = ConvertFromDecimal(decimalNumber, targetBase);

            Console.WriteLine($"The converted number is: {result}");
        }

        static int ConvertToDecimal(string number, int baseNum)
        {
            int result = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = number[i] - '0';
                result += digit * (int)Math.Pow(baseNum, number.Length - 1 - i);
            }
            return result;
        }

        static string ConvertFromDecimal(int decimalNumber, int baseNum)
        {
            string result = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % baseNum;
                result = remainder + result;
                decimalNumber /= baseNum;
            }
            return result;
        }
    }
}
