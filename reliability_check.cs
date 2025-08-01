
using System;

class Program
{
    static void Main()
    {
        string isbn = "3551551673";
        
        if (IsISBNValid(isbn))
        {
            Console.WriteLine($"{isbn} is a valid ISBN number.");
        }
        else
        {
            Console.WriteLine($"{isbn} is not a valid ISBN number.");
        }
    }

    static bool IsISBNValid(string isbn)
    {
        if (isbn.Length != 10)
        {
            return false;
        }

        int sum = 0;
        for (int i = 0; i < 9; i++)
        {
            if (!char.IsDigit(isbn[i]))
            {
                return false;
            }
            sum += (i + 1) * int.Parse(isbn[i].ToString());
        }

        char lastChar = isbn[9];
        if (lastChar != 'X' && !char.IsDigit(lastChar))
        {
            return false;
        }

        sum += (lastChar == 'X' ? 10 : int.Parse(lastChar.ToString())) * 10;

        return sum % 11 == 0;
    }
}
