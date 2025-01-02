
using System;

class CaesarCipher
{
    static void Main()
    {
        string text = "Hello, World!";
        int key = 3;

        string encryptedText = Encrypt(text, key);
        Console.WriteLine("Encrypted Text: " + encryptedText);

        string decryptedText = Decrypt(encryptedText, key);
        Console.WriteLine("Decrypted Text: " + decryptedText);
    }

    static string Encrypt(string text, int key)
    {
        char[] chars = text.ToCharArray();
        for (int i = 0; i < chars.Length; i++)
        {
            if (chars[i] >= 'a' && chars[i] <= 'z')
            {
                chars[i] = (char)(((chars[i] - 'a' + key) % 26) + 'a');
            }
            else if (chars[i] >= 'A' && chars[i] <= 'Z')
            {
                chars[i] = (char)(((chars[i] - 'A' + key) % 26) + 'A');
            }
        }
        return new string(chars);
    }

    static string Decrypt(string text, int key)
    {
        return Encrypt(text, 26 - key);
    }
}
