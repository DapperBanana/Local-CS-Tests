
using System;

namespace NumberConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to convert: ");
            string inputNumber = Console.ReadLine();

            Console.WriteLine("Enter the base of the input number: ");
            int inputBase = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the base to convert to: ");
            int outputBase = int.Parse(Console.ReadLine());

            string result = ConvertBase(inputNumber, inputBase, outputBase);

            Console.WriteLine($"The number {inputNumber} in base {inputBase} is equivalent to {result} in base {outputBase}");
        }

        static string ConvertBase(string number, int inputBase, int outputBase)
        {
            int decimalNumber = ConvertToDecimal(number, inputBase);

            return ConvertFromDecimal(decimalNumber, outputBase);
        }

        static int ConvertToDecimal(string number, int inputBase)
        {
            int decimalNumber = 0;
            for (int i = 0; i < number.Length; i++)
            {
                int digitValue = (number[i] >= '0' && number[i] <= '9') ? number[i] - '0' : number[i] - 'A' + 10;
                decimalNumber = decimalNumber * inputBase + digitValue;
            }
            return decimalNumber;
        }

        static string ConvertFromDecimal(int decimalNumber, int outputBase)
        {
            string result = "";
            while (decimalNumber > 0)
            {
                int remainder = decimalNumber % outputBase;
                char digit = (char)((remainder < 10) ? remainder + '0' : remainder - 10 + 'A');
                result = digit + result;
                decimalNumber /= outputBase;
            }
            return result;
        }
    }
}
