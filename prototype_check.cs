
using System;

class CaesarCipher
{
    static string Encrypt(string plainText, int shift)
    {
        string cipherText = "";
        foreach (char c in plainText)
        {
            if (char.IsLetter(c))
            {
                char newChar = (char)(c + shift);
                if (char.IsLower(c))
                {
                    if (newChar > 'z')
                        newChar = (char)(newChar - 26);
                }
                else
                {
                    if (newChar > 'Z')
                        newChar = (char)(newChar - 26);
                }
                cipherText += newChar;
            }
            else
            {
                cipherText += c;
            }
        }
        return cipherText;
    }

    static string Decrypt(string cipherText, int shift)
    {
        return Encrypt(cipherText, -shift);
    }

    static void Main()
    {
        string plainText = "Hello, world!";
        int shift = 3;
        string encryptedText = Encrypt(plainText, shift);
        string decryptedText = Decrypt(encryptedText, shift);

        Console.WriteLine("Plain Text: " + plainText);
        Console.WriteLine("Encrypted Text: " + encryptedText);
        Console.WriteLine("Decrypted Text: " + decryptedText);
    }
}
