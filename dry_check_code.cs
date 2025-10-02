
using System;

class CaesarCipher
{
    static string Encrypt(string text, int key)
    {
        string result = "";
        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                result += (char)((((c + key) - offset) % 26) + offset);
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

    static void Main()
    {
        Console.WriteLine("Enter text to encrypt:");
        string plaintext = Console.ReadLine();

        Console.WriteLine("Enter encryption key:");
        int key = int.Parse(Console.ReadLine());

        string encrypted = Encrypt(plaintext, key);
        Console.WriteLine("Encrypted text: " + encrypted);

        string decrypted = Decrypt(encrypted, key);
        Console.WriteLine("Decrypted text: " + decrypted);
    }
}
