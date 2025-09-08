
using System;

class Program
{
    static bool IsValidCreditCardNumber(string creditCardNumber)
    {
        int[] digits = creditCardNumber
                        .Where(char.IsDigit)
                        .Select(c => int.Parse(c.ToString()))
                        .ToArray();

        int checksum = 0;
        bool doubleDigit = false;

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            if (doubleDigit)
            {
                digits[i] *= 2;
                if (digits[i] > 9)
                {
                    digits[i] -= 9;
                }
            }

            checksum += digits[i];
            doubleDigit = !doubleDigit;
        }

        return checksum % 10 == 0;
    }

    static void Main()
    {
        Console.Write("Enter a credit card number: ");
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
}
