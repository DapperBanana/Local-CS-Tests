
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter credit card number: ");
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
        creditCardNumber = creditCardNumber.Replace(" ", "");

        int sum = 0;
        int digit;
        bool doubled = false;

        for (int i = creditCardNumber.Length - 1; i >= 0; i--)
        {
            if (!int.TryParse(creditCardNumber.Substring(i, 1), out digit))
            {
                return false;
            }

            if (doubled)
            {
                digit *= 2;
                if (digit > 9)
                {
                    digit -= 9;
                }
            }

            sum += digit;
            doubled = !doubled;
        }

        return sum % 10 == 0;
    }
}
