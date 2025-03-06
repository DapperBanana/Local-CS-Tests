
using System;

class CaesarCipher
{
    static void Main()
    {
        Console.WriteLine("Enter text to encrypt:");
        string plainText = Console.ReadLine();
        
        const int shift = 3; // Shift value for Caesar cipher
        
        string cipherText = Encrypt(plainText, shift);
        Console.WriteLine("Encrypted text: " + cipherText);
        
        string decryptedText = Decrypt(cipherText, shift);
        Console.WriteLine("Decrypted text: " + decryptedText);
    }
    
    static string Encrypt(string input, int shift)
    {
        string result = "";
        
        foreach(char c in input)
        {
            if(char.IsLetter(c))
            {
                char encryptedChar = (char)(c + shift);
                if(char.IsLower(c) && encryptedChar > 'z')
                {
                    encryptedChar = (char)(encryptedChar - 26); // Wrap around for small letters
                }
                else if(char.IsUpper(c) && encryptedChar > 'Z')
                {
                    encryptedChar = (char)(encryptedChar - 26); // Wrap around for capital letters 
                }
                result += encryptedChar;
            }
            else
            {
                result += c;
            }
        }
        
        return result;
    }
    
    static string Decrypt(string input, int shift)
    {
        return Encrypt(input, 26 - shift); // Decrypt by shifting back by the same amount
    }
}
