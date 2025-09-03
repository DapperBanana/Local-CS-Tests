
using System;

class CaesarCipher
{
    static void Main()
    {
        Console.WriteLine("Enter text to encrypt:");
        string plainText = Console.ReadLine();
        
        Console.WriteLine("Enter the shift value:");
        int shift = int.Parse(Console.ReadLine());
        
        string cipherText = Encrypt(plainText, shift);
        Console.WriteLine($"Encrypted text: {cipherText}");
        
        string decryptedText = Decrypt(cipherText, shift);
        Console.WriteLine($"Decrypted text: {decryptedText}");
    }
    
    static string Encrypt(string text, int shift)
    {
        string result = "";
        
        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                char encryptedChar = (char)(((char.ToUpper(c) - 'A' + shift) % 26) + 'A');
                result += char.IsLower(c) ? char.ToLower(encryptedChar) : encryptedChar;
            }
            else
            {
                result += c;
            }
        }
        
        return result;
    }
    
    static string Decrypt(string text, int shift)
    {
        return Encrypt(text, 26 - shift);
    }
}
