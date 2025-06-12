
using System;

class CaesarCipher
{
    static void Main()
    {
        Console.Write("Enter text to encrypt: ");
        string plaintext = Console.ReadLine();

        int shiftKey = 3; // Shift key for Caesar cipher

        string cipherText = Encrypt(plaintext, shiftKey);
        Console.WriteLine("Encrypted text: " + cipherText);

        string decryptedText = Decrypt(cipherText, shiftKey);
        Console.WriteLine("Decrypted text: " + decryptedText);
    }

    static string Encrypt(string text, int key)
    {
        char[] chars = text.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            char c = chars[i];

            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                chars[i] = (char)((c + key - offset) % 26 + offset);
            }
        }

        return new string(chars);
    }

    static string Decrypt(string text, int key)
    {
        return Encrypt(text, 26 - key);
    }
}
