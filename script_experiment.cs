
using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string creditCardNumber = "4111-1111-1111-1111"; // Insert the credit card number here

        bool isValid = IsValidCreditCardNumber(creditCardNumber);
        
        if (isValid)
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
        string cleanedNumber = Regex.Replace(creditCardNumber, "[^0-9]", "");

        // Check if the cleaned number is 16 digits long and passes the Luhn algorithm
        if (cleanedNumber.Length != 16)
        {
            return false;
        }

        return LuhnAlgorithmCheck(cleanedNumber);
    }

    static bool LuhnAlgorithmCheck(string number)
    {
        int sum = 0;
        bool alternate = false;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            int digit = int.Parse(number[i].ToString());
            
            if (alternate)
            {
                digit *= 2;
                if (digit > 9)
                {
                    digit -= 9;
                }
            }

            sum += digit;
            alternate = !alternate;
        }

        return sum % 10 == 0;
    }
}
