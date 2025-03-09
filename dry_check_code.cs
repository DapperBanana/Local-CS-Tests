
using System;

class Program
{
    static void Main()
    {
        string creditCardNumber = "1234 5678 9012 3456"; // Example credit card number
        
        if (IsValidCreditCard(creditCardNumber))
        {
            Console.WriteLine("Valid credit card number");
        }
        else
        {
            Console.WriteLine("Invalid credit card number");
        }
    }

    static bool IsValidCreditCard(string creditCardNumber)
    {
        // Remove any whitespace from the credit card number
        creditCardNumber = creditCardNumber.Replace(" ", "");

        // Check if the credit card number is numerical and has a length of 16
        if (creditCardNumber.Length != 16 || !IsNumeric(creditCardNumber))
        {
            return false;
        }

        // Other validation rules can be added here...

        return true;
    }

    static bool IsNumeric(string value)
    {
        foreach (char c in value)
        {
            if (!char.IsDigit(c))
            {
                return false;
            }
        }

        return true;
    }
}
