
using System;

class Program
{
    static bool IsValidCreditCardNumber(string creditCardNumber)
    {
        creditCardNumber = creditCardNumber.Replace(" ", "");

        int sum = 0;
        bool alternate = false;

        for (int i = creditCardNumber.Length - 1; i >= 0; i--)
        {
            int num = int.Parse(creditCardNumber[i].ToString());

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

        return (sum % 10 == 0);
    }

    static void Main()
    {
        string creditCardNumber = "4111 1111 1111 1111";

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
