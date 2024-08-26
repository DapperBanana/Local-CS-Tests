
using System;

class Program
{
    static void Main()
    {
        string creditCardNumber = "1234567890123456";
        bool isValidCreditCard = IsValidCreditCard(creditCardNumber);

        if (isValidCreditCard)
        {
            Console.WriteLine("The credit card number is valid.");
        }
        else
        {
            Console.WriteLine("The credit card number is not valid.");
        }
    }

    static bool IsValidCreditCard(string creditCardNumber)
    {
        int total = 0;
        bool isSecondDigit = false;

        for (int i = creditCardNumber.Length - 1; i >= 0; i--)
        {
            int digit = creditCardNumber[i] - '0';

            if (isSecondDigit)
            {
                digit *= 2;
            }

            total += digit / 10 + digit % 10;
            isSecondDigit = !isSecondDigit;
        }

        return total % 10 == 0;
    }
}
