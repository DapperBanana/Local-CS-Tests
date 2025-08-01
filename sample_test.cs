
using System;

class CaesarCipher
{
    static void Main()
    {
        Console.WriteLine("Enter text to encrypt:");
        string plainText = Console.ReadLine();

        Console.WriteLine("Enter key:");
        int key = int.Parse(Console.ReadLine());

        string encryptedText = Encrypt(plainText, key);
        Console.WriteLine($"Encrypted text: {encryptedText}");

        string decryptedText = Decrypt(encryptedText, key);
        Console.WriteLine($"Decrypted text: {decryptedText}");
    }

    static string Encrypt(string text, int key)
    {
        string result = "";

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                char start = char.IsUpper(c) ? 'A' : 'a';
                result += (char)((((c + key) - start) % 26) + start);
            }
            else
            {
                result += c;
            }
        }

        return result;
    }

    static string Decrypt(string text, int key)
    {
        return Encrypt(text, 26 - key);
    }
}
