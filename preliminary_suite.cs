
using System;

namespace BaseConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number to convert: ");
            string num = Console.ReadLine();

            Console.WriteLine("Enter the base of the number (2 for binary, 10 for decimal): ");
            int baseFrom = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the base to convert to (2 for binary, 10 for decimal): ");
            int baseTo = Convert.ToInt32(Console.ReadLine());

            string convertedNum = ConvertBase(num, baseFrom, baseTo);
            Console.WriteLine($"Converted Number: {convertedNum}");
        }

        static string ConvertBase(string num, int baseFrom, int baseTo)
        {
            if (baseFrom == baseTo)
            {
                return num;
            }

            if (baseFrom == 2 && baseTo == 10)
            {
                return Convert.ToInt32(num, 2).ToString();
            }
            else if (baseFrom == 10 && baseTo == 2)
            {
                return Convert.ToString(Convert.ToInt32(num), 2);
            }

            return null;
        }
    }
}
