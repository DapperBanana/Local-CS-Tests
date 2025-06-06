
using System;

class Program
{
    static bool ValidateCreditCardNumber(string cardNumber)
    {
        int[] arr = new int[cardNumber.Length];
        for (int i = 0; i < cardNumber.Length; i++)
        {
            arr[i] = int.Parse(cardNumber[i].ToString());
        }

        int sum = 0;
        bool doubleDigit = false;

        for (int i = arr.Length - 2; i >= 0; i -= 2)
        {
            int num = arr[i] * 2;
            if (num > 9)
            {
                num = num % 10 + num / 10;
            }
            arr[i] = num;
        }

        foreach (int num in arr)
        {
            sum += num;
        }

        return sum % 10 == 0;
    }

    static void Main()
    {
        Console.WriteLine("Enter credit card number:");
        string cardNumber = Console.ReadLine().Replace(" ", "");

        if (ValidateCreditCardNumber(cardNumber))
        {
            Console.WriteLine("Credit card number is valid.");
        }
        else
        {
            Console.WriteLine("Credit card number is invalid.");
        }
    }
}
