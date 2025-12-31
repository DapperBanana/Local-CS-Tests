using System;

class DecimalToBinaryConverter
{
    static void Main()
    {
        Console.Write("Enter a decimal number: ");
        if (int.TryParse(Console.ReadLine(), out int decimalNumber))
        {
            string binaryRepresentation = ConvertToBinary(decimalNumber);
            Console.WriteLine($"Binary representation: {binaryRepresentation}");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid decimal number.");
        }
    }

    static string ConvertToBinary(int decimalNumber)
    {
        if (decimalNumber == 0)
            return "0";

        string binary = "";
        int number = Math.Abs(decimalNumber);

        while (number > 0)
        {
            binary = (number % 2) + binary;
            number /= 2;
        }

        if (decimalNumber < 0)
            binary = "-" + binary;

        return binary;
    }
}