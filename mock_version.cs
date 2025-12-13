using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a credit card number:");
        string input = Console.ReadLine();

        if (IsValidCreditCardNumber(input))
        {
            Console.WriteLine("The credit card number is valid.");
        }
        else
        {
            Console.WriteLine("The credit card number is invalid.");
        }
    }

    static bool IsValidCreditCardNumber(string number)
    {
        if (string.IsNullOrWhiteSpace(number))
            return false;

        // Remove any spaces or hyphens
        string sanitizedNumber = number.Replace(" ", "").Replace("-", "");

        // Check if all characters are digits
        foreach (char c in sanitizedNumber)
        {
            if (!char.IsDigit(c))
                return false;
        }

        return LuhnCheck(sanitizedNumber);
    }

    static bool LuhnCheck(string number)
    {
        int sum = 0;
        bool alternate = false;

        for (int i = number.Length - 1; i >= 0; i--)
        {
            int n = int.Parse(number[i].ToString());

            if (alternate)
            {
                n *= 2;
                if (n > 9)
                    n -= 9;
            }

            sum += n;
            alternate = !alternate;
        }

        return (sum % 10 == 0);
    }
}