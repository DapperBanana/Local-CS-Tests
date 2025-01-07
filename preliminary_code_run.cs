
using System;

namespace NumberBaseConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number you want to convert: ");
            string inputNumber = Console.ReadLine();

            Console.WriteLine("Enter the base of the input number: ");
            int inputBase = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the base you want to convert to: ");
            int outputBase = int.Parse(Console.ReadLine());

            int decimalNumber = ConvertToDecimal(inputNumber, inputBase);
            string outputNumber = ConvertFromDecimal(decimalNumber, outputBase);

            Console.WriteLine($"Converted number: {outputNumber}");
        }

        // Method to convert a number from any base to decimal
        static int ConvertToDecimal(string inputNumber, int inputBase)
        {
            int decimalNumber = 0;
            for (int i = 0; i < inputNumber.Length; i++)
            {
                decimalNumber = decimalNumber * inputBase + Convert.ToInt32(inputNumber[i].ToString(), inputBase);
            }

            return decimalNumber;
        }

        // Method to convert a decimal number to any base
        static string ConvertFromDecimal(int decimalNumber, int outputBase)
        {
            string outputNumber = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % outputBase;
                outputNumber = remainder.ToString() + outputNumber;
                decimalNumber /= outputBase;
            }

            return outputNumber;
        }
    }
}
