
using System;

class CaesarCipher
{
    static void Main()
    {
        Console.WriteLine("Enter text to encrypt:");
        string text = Console.ReadLine().ToUpper();
        Console.WriteLine("Enter shift value:");
        int shift = int.Parse(Console.ReadLine());

        string encryptedText = Encrypt(text, shift);
        Console.WriteLine("Encrypted text: " + encryptedText);

        string decryptedText = Decrypt(encryptedText, shift);
        Console.WriteLine("Decrypted text: " + decryptedText);
    }

    static string Encrypt(string text, int shift)
    {
        string result = "";
        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                char encryptedChar = (char)(((c - 'A' + shift) % 26) + 'A');
                result += encryptedChar;
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
