
using System;

class Program
{
    static bool IsValidCreditCardNumber(string cardNumber)
    {
        int sum = 0;
        bool alternate = false;
        char[] reversedCardNumber = cardNumber.ToCharArray();
        Array.Reverse(reversedCardNumber);

        foreach (char digit in reversedCardNumber)
        {
            if (!char.IsDigit(digit))
            {
                return false;
            }

            int num = digit - '0';

            if (alternate)
            {
                num *= 2;
                if (num > 9)
                {
                    num = (num % 10) + 1;
                }
            }

            sum += num;
            alternate = !alternate;
        }

        return sum % 10 == 0;
    }

    static void Main(string[] args)
    {
        string cardNumber = "1234567890123456"; // Change this to the credit card number you want to check

        if (IsValidCreditCardNumber(cardNumber))
        {
            Console.WriteLine("The credit card number is valid.");
        }
        else
        {
            Console.WriteLine("The credit card number is invalid.");
        }
    }
}
