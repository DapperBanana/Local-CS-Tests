
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string creditCardNumber = "1234-5678-9012-3456"; // Change this to the credit card number you want to check
        
        if (IsValidCreditCardNumber(creditCardNumber))
        {
            Console.WriteLine("The credit card number is valid.");
        }
        else
        {
            Console.WriteLine("The credit card number is invalid.");
        }
    }

    static bool IsValidCreditCardNumber(string creditCardNumber)
    {
        // Remove any dashes or spaces from the credit card number
        creditCardNumber = Regex.Replace(creditCardNumber, @"[-\s]", "");

        // Check if the credit card number contains only digits and has a length of 16
        if (Regex.IsMatch(creditCardNumber, @"^\d{16}$"))
        {
            return true;
        }

        return false;
    }
}
