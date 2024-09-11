
using System;

class CaesarCipher
{
    // Encrypts text using the Caesar cipher
    public static string Encrypt(string text, int key)
    {
        string result = "";
        
        foreach(char c in text)
        {
            if (char.IsLetter(c))
            {
                char shift = char.IsUpper(c) ? 'A' : 'a';
                result += (char)(((c + key - shift) % 26) + shift);
            }
            else
            {
                result += c;
            }
        }
        
        return result;
    }
    
    // Decrypts text using the Caesar cipher
    public static string Decrypt(string text, int key)
    {
        return Encrypt(text, 26 - key);
    }
    
    static void Main()
    {
        string text = "Hello World!";
        int key = 3;
        
        Console.WriteLine("Original text: " + text);
        
        string encryptedText = Encrypt(text, key);
        Console.WriteLine("Encrypted text: " + encryptedText);
        
        string decryptedText = Decrypt(encryptedText, key);
        Console.WriteLine("Decrypted text: " + decryptedText);
    }
}
