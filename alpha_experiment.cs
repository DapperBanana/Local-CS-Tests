
using System;
using System.Text;

class Program
{
    static void Main()
    {
        string plaintext = "Hello, World!";
        int shiftKey = 3;

        string encryptedText = Encrypt(plaintext, shiftKey);
        string decryptedText = Decrypt(encryptedText, shiftKey);

        Console.WriteLine("Plaintext: " + plaintext);
        Console.WriteLine("Encrypted Text: " + encryptedText);
        Console.WriteLine("Decrypted Text: " + decryptedText);
    }

    static string Encrypt(string text, int shiftKey)
    {
        StringBuilder result = new StringBuilder();
        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                char shiftedChar = (char)(((char.ToUpper(c) - 'A' + shiftKey) % 26) + 'A');
                result.Append(char.IsLower(c) ? char.ToLower(shiftedChar) : shiftedChar);
            }
            else
            {
                result.Append(c);
            }
        }
        return result.ToString();
    }

    static string Decrypt(string text, int shiftKey)
    {
        return Encrypt(text, 26 - shiftKey);
    }
}
