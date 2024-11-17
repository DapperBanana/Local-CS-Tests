
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a credit card number:");
        string creditCardNumber = Console.ReadLine();

        if (IsValidCreditCardNumber(creditCardNumber))
        {
            Console.WriteLine("Valid credit card number");
        }
        else
        {
            Console.WriteLine("Invalid credit card number");
        }
    }

    static bool IsValidCreditCardNumber(string creditCardNumber)
    {
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
