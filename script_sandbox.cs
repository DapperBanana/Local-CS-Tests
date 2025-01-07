
using System;

class Program
{
    static bool IsValidCreditCardNumber(string creditCardNumber)
    {
        int[] digits = creditCardNumber.Select(c => c - '0').ToArray();
        
        if (digits.Length != 16)
        {
            return false;
        }

        int sum = 0;
        bool doubleDigit = false;

        for (int i = digits.Length - 1; i >= 0; i--)
        {
            int digit = digits[i];

            if (doubleDigit)
            {
                digit *= 2;
                if (digit > 9)
                {
                    digit -= 9;
                }
            }

            sum += digit;
            doubleDigit = !doubleDigit;
        }

        return sum % 10 == 0;
    }

    static void Main()
    {
        string creditCardNumber = "4852683910361027"; // Replace with the credit card number you want to check
        
        if (IsValidCreditCardNumber(creditCardNumber))
        {
            Console.WriteLine("The credit card number is valid.");
        }
        else
        {
            Console.WriteLine("The credit card number is invalid.");
        }
    }
}
