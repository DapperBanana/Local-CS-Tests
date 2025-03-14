
using System;

namespace NumberBaseConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to convert:");
            string number = Console.ReadLine();

            Console.WriteLine("Enter the current base:");
            int currentBase = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the desired base:");
            int desiredBase = Convert.ToInt32(Console.ReadLine());

            // Convert the number to decimal first
            int decimalNumber = Convert.ToInt32(number, currentBase);

            // Convert the decimal number to the desired base
            string result = Convert.ToString(decimalNumber, desiredBase);

            Console.WriteLine($"The number {number} in base {currentBase} is {result} in base {desiredBase}.");
        }
    }
}
