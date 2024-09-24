
using System;

class CaesarCipher
{
    public static string Encrypt(string text, int key)
    {
        string result = "";

        foreach (char ch in text)
        {
            if (char.IsLetter(ch))
            {
                char offset = char.IsUpper(ch) ? 'A' : 'a';
                result += (char)((((ch + key) - offset) % 26) + offset);
            }
            else
            {
                result += ch;
            }
        }

        return result;
    }

    public static string Decrypt(string text, int key)
    {
        return Encrypt(text, 26 - key);
    }

    static void Main()
    {
        string text = "Hello, World!";
        int key = 3;

        string encryptedText = Encrypt(text, key);
        Console.WriteLine("Encrypted text: " + encryptedText);

        string decryptedText = Decrypt(encryptedText, key);
        Console.WriteLine("Decrypted text: " + decryptedText);
    }
}
