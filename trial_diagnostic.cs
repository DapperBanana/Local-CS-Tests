
using System;

class Program
{
    static void Main()
    {
        string creditCardNumber = "1234 5678 9012 3456"; // Enter the credit card number here

        bool isValid = IsValidCreditCardNumber(creditCardNumber);

        if (isValid)
        {
            Console.WriteLine("The credit card number is valid.");
        }
        else
        {
            Console.WriteLine("The credit card number is invalid.");
        }
    }

    static bool IsValidCreditCardNumber(string creditCardNumber)
    {
        // Remove any spaces from the credit card number
        creditCardNumber = creditCardNumber.Replace(" ", "");

        // Check if the credit card number contains only digits
        if (!long.TryParse(creditCardNumber, out _))
        {
            return false;
        }

        // Check if the credit card number is of valid length
        if (creditCardNumber.Length != 16)
        {
            return false;
        }

        // Check if the credit card number satisfies the Luhn algorithm
        int sum = 0;
        bool isSecondDigit = false;

        for (int i = creditCardNumber.Length - 1; i >= 0; i--)
        {
            int digit = creditCardNumber[i] - '0';

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
}
