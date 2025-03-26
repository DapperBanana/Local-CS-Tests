
using System;

class Program
{
    static bool IsCreditCardValid(string creditCardNumber)
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

    static void Main()
    {
        string creditCardNumber = "4532015112830366";

        if (IsCreditCardValid(creditCardNumber))
        {
            Console.WriteLine("The credit card number is valid.");
        }
        else
        {
            Console.WriteLine("The credit card number is not valid.");
        }
    }
}
