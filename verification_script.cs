
using System;

class ISBNValidator
{
    static void Main()
    {
        string isbn = "978-3-16-148410-0"; // Replace with the ISBN number you want to validate
        
        bool isValid = ValidateISBN(isbn);
        
        if (isValid)
        {
            Console.WriteLine("The ISBN number {0} is valid.", isbn);
        }
        else
        {
            Console.WriteLine("The ISBN number {0} is invalid.", isbn);
        }
    }
    
    static bool ValidateISBN(string isbn)
    {
        isbn = isbn.Replace("-", "").Replace(" ", ""); // Remove dashes and spaces
        
        if (isbn.Length != 13)
        {
            return false;
        }
        
        int checkDigit = int.Parse(isbn.Substring(12, 1));
        int sum = 0;
        
        for (int i = 0; i < 12; i++)
        {
            sum += int.Parse(isbn.Substring(i, 1)) * (i % 2 == 0 ? 1 : 3);
        }
        
        int remainder = sum % 10;
        int calculatedCheckDigit = (10 - remainder) % 10;
        
        return checkDigit == calculatedCheckDigit;
    }
}
