
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter credit card number: ");
        string input = Console.ReadLine();

        bool isValid = CheckCreditCardNumber(input);

        if (isValid)
        {
            Console.WriteLine("Valid credit card number.");
        }
        else
        {
            Console.WriteLine("Invalid credit card number.");
        }
    }

    static bool CheckCreditCardNumber(string creditCardNumber)
    {
        // Remove any spaces or dashes from the credit card number
        creditCardNumber = creditCardNumber.Replace(" ", "").Replace("-", "");

        // Check if the credit card number is numeric and has a length of 16
        if (!long.TryParse(creditCardNumber, out _) || creditCardNumber.Length != 16)
        {
            return false;
        }

        // Check Luhn algorithm validity
        int sum = 0;
        for (int i = 0; i < creditCardNumber.Length; i++)
        {
            int digit = creditCardNumber[i] - '0';

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
}
