
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a credit card number:");
        string creditCardNumber = Console.ReadLine();

        if (IsValidCreditCardNumber(creditCardNumber))
        {
            Console.WriteLine("Valid credit card number.");
        }
        else
        {
            Console.WriteLine("Invalid credit card number.");
        }
    }

    public static bool IsValidCreditCardNumber(string creditCardNumber)
    {
        // Remove any spaces or dashes from the credit card number
        creditCardNumber = creditCardNumber.Replace(" ", "").Replace("-", "");

        // Check if the length of the credit card number is valid
        if (creditCardNumber.Length < 13 || creditCardNumber.Length > 16)
        {
            return false;
        }

        // Check if the credit card number contains only digits
        foreach (char c in creditCardNumber)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }

        // Perform Luhn Algorithm to validate the credit card number
        int sum = 0;
        for (int i = creditCardNumber.Length - 1; i >= 0; i--)
        {
            int digit = creditCardNumber[i] - '0';
            if (i % 2 == creditCardNumber.Length % 2)
            {
                digit *= 2;
                if (digit > 9)
                {
                    digit -= 9;
                }
            }
            sum += digit;
        }

        return sum % 10 == 0;
    }
}
