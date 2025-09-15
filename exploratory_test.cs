
using System;

class CaesarCipher
{
    static char Encrypt(char ch, int key)
    {
        if (!char.IsLetter(ch))
        {
            return ch;
        }

        char offset = char.IsUpper(ch) ? 'A' : 'a';
        return (char)((((ch + key) - offset) % 26) + offset);
    }

    static char Decrypt(char ch, int key)
    {
        return Encrypt(ch, 26 - key);
    }

    static string EncryptText(string text, int key)
    {
        char[] result = new char[text.Length];

        for (int i = 0; i < text.Length; i++)
        {
            result[i] = Encrypt(text[i], key);
        }

        return new string(result);
    }

    static string DecryptText(string text, int key)
    {
        return EncryptText(text, 26 - key);
    }

    static void Main()
    {
        Console.Write("Enter text to encrypt: ");
        string input = Console.ReadLine();

        Console.Write("Enter encryption key (0-25): ");
        int key = int.Parse(Console.ReadLine());

        string encryptedText = EncryptText(input, key);
        Console.WriteLine($"Encrypted Text: {encryptedText}");

        string decryptedText = DecryptText(encryptedText, key);
        Console.WriteLine($"Decrypted Text: {decryptedText}");
    }
}
