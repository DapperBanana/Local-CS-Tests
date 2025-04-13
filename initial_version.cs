
using System;
using System.Text.RegularExpressions;

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

    static bool IsValidCreditCardNumber(string creditCardNumber)
    {
        // Remove any non-digit characters from the credit card number
        string cleanCreditCardNumber = Regex.Replace(creditCardNumber, "[^0-9]", "");

        // Check if the credit card number is 16 digits long and starts with a valid prefix
        if (cleanCreditCardNumber.Length != 16 || !HasValidPrefix(cleanCreditCardNumber))
        {
            return false;
        }

        // Perform Luhn algorithm to validate the credit card number
        int sum = 0;
        for (int i = 0; i < cleanCreditCardNumber.Length; i++)
        {
            int digit = int.Parse(cleanCreditCardNumber[i].ToString());

            if (i % 2 == 0)
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

    static bool HasValidPrefix(string creditCardNumber)
    {
        // Define valid prefix patterns for credit card numbers
        string[] validPrefixes = { "4", "5", "37", "6" };

        foreach (string prefix in validPrefixes)
        {
            if (creditCardNumber.StartsWith(prefix))
            {
                return true;
            }
        }

        return false;
    }
}
