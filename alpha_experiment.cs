
using System;

class Program
{
    static bool IsCreditCardValid(string creditCardNumber)
    {
        creditCardNumber = creditCardNumber.Replace(" ", "");

        int sum = 0;
        bool isSecondDigit = false;

        for (int i = creditCardNumber.Length - 1; i >= 0; i--)
        {
            int digit = creditCardNumber[i] - '0';

            if (isSecondDigit)
            {
                digit *= 2;
                if (digit > 9)
                    digit = digit - 9;
            }

            sum += digit;
            isSecondDigit = !isSecondDigit;
        }

        return sum % 10 == 0;
    }

    static void Main()
    {
        string creditCardNumber = "4111 1111 1111 1111";

        if (IsCreditCardValid(creditCardNumber))
            Console.WriteLine("Valid credit card number.");
        else
            Console.WriteLine("Invalid credit card number.");
    }
}
