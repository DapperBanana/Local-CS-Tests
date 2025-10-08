
using System;

namespace NumberBaseConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            string number = Console.ReadLine();

            Console.WriteLine("Enter the base of the number (2 for binary, 8 for octal, 10 for decimal, 16 for hexadecimal): ");
            int fromBase = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the base to convert to (2 for binary, 8 for octal, 10 for decimal, 16 for hexadecimal): ");
            int toBase = Convert.ToInt32(Console.ReadLine());

            string result = ConvertBase(number, fromBase, toBase);

            Console.WriteLine($"Result: {result}");
        }

        static string ConvertBase(string number, int fromBase, int toBase)
        {
            string result = Convert.ToString(Convert.ToInt32(number, fromBase), toBase);
            return result;
        }
    }
}
