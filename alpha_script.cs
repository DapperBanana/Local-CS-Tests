
using System;

class Program
{
    static void Main()
    {
        string creditCardNumber = "1234123412341234"; // Change this value to test different credit card numbers

        bool isValid = IsCreditCardNumberValid(creditCardNumber);

        if(isValid)
        {
            Console.WriteLine("The credit card number is valid.");
        }
        else
        {
            Console.WriteLine("The credit card number is invalid.");
        }
    }

    static bool IsCreditCardNumberValid(string creditCardNumber)
    {
        // Check if the credit card number is a 16-digit number
        if(creditCardNumber.Length != 16)
        {
            return false;
        }

        // Check if the credit card number contains only digits
        foreach(char c in creditCardNumber)
        {
            if(!Char.IsDigit(c))
            {
                return false;
            }
        }

        // Check if the credit card number passes the Luhn algorithm
        int sum = 0;
        for(int i = 0; i < creditCardNumber.Length; i++)
        {
            int digit = int.Parse(creditCardNumber[i].ToString());

            if(i % 2 == 0)
            {
                digit *= 2;
                if(digit > 9)
                {
                    digit -= 9;
                }
            }

            sum += digit;
        }

        return sum % 10 == 0;
    }
}
