
using System;

class Program
{
    static bool IsValidCreditCardNumber(string creditCardNumber)
    {
        // Remove any non-digit characters from the input string
        string cleanedNumber = "";
        foreach (char c in creditCardNumber)
        {
            if (char.IsDigit(c))
            {
                cleanedNumber += c;
            }
        }

        // Check if the input string is of valid length (between 13 and 16 digits)
        if (cleanedNumber.Length < 13 || cleanedNumber.Length > 16)
        {
            return false;
        }

        // Perform Luhn algorithm to validate the credit card number
        int sum = 0;
        bool isSecondDigit = false;
        for (int i = cleanedNumber.Length - 1; i >= 0; i--)
        {
            int digit = cleanedNumber[i] - '0';

            if (isSecondDigit)
            {
                digit *= 2;

                if (digit > 9)
                {
                    digit = digit / 10 + digit % 10;
                }
            }

            sum += digit;
            isSecondDigit = !isSecondDigit;
        }

        return sum % 10 == 0;
    }

    static void Main()
    {
        // Input credit card number
        Console.Write("Enter a credit card number: ");
        string creditCardNumber = Console.ReadLine();

        // Check if the credit card number is valid
        if (IsValidCreditCardNumber(creditCardNumber))
        {
            Console.WriteLine("Valid credit card number.");
        }
        else
        {
            Console.WriteLine("Invalid credit card number.");
        }
    }
}
