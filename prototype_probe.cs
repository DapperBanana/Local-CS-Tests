
using System;

class CaesarCipher
{
    // Function to encrypt text using Caesar cipher
    static string Encrypt(string text, int shift)
    {
        char[] charArray = text.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            charArray[i] = (char)(charArray[i] + shift);
        }

        return new string(charArray);
    }

    // Function to decrypt text using Caesar cipher
    static string Decrypt(string text, int shift)
    {
        char[] charArray = text.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            charArray[i] = (char)(charArray[i] - shift);
        }

        return new string(charArray);
    }

    public static void Main()
    {
        string plaintext = "hello world";
        int shift = 3;

        string encryptedText = Encrypt(plaintext, shift);
        string decryptedText = Decrypt(encryptedText, shift);

        Console.WriteLine("Original Text: " + plaintext);
        Console.WriteLine("Encrypted Text: " + encryptedText);
        Console.WriteLine("Decrypted Text: " + decryptedText);
    }
}
