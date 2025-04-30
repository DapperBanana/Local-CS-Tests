
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a credit card number:");
        string creditCardNumber = Console.ReadLine();

        if (IsCreditCardNumberValid(creditCardNumber))
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
        // Remove any spaces or dashes from the credit card number
        creditCardNumber = creditCardNumber.Replace(" ", "").Replace("-", "");

        // Check if the credit card number contains only digits and is of valid length
        if (!long.TryParse(creditCardNumber, out _))
        {
            return false;
        }
        
        if (creditCardNumber.Length < 13 || creditCardNumber.Length > 16)
        {
            return false;
        }

        // Check if the credit card number passes the Luhn algorithm
        int sum = 0;
        bool isEven = false;
        
        for (int i = creditCardNumber.Length - 1; i >= 0; i--)
        {
            int digit = int.Parse(creditCardNumber[i].ToString());
            
            if (isEven)
            {
                digit *= 2;
                
                if (digit > 9)
                {
                    digit -= 9;
                }
            }
            
            sum += digit;
            isEven = !isEven;
        }

        return sum % 10 == 0;
    }
}
