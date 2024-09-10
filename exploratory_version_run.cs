
using System;

class CaesarCipher
{
    static string Encrypt(string text, int shift)
    {
        string encryptedText = "";
        foreach (char letter in text)
        {
            if (char.IsLetter(letter))
            {
                char encryptedLetter = (char)(letter + shift);
                if (char.IsUpper(letter) && encryptedLetter > 'Z')
                {
                    encryptedLetter = (char)(encryptedLetter - 26);
                }
                else if (char.IsLower(letter) && encryptedLetter > 'z')
                {
                    encryptedLetter = (char)(encryptedLetter - 26);
                }
                encryptedText += encryptedLetter;
            }
            else
            {
                encryptedText += letter;
            }
        }
        return encryptedText;
    }

    static string Decrypt(string text, int shift)
    {
        string decryptedText = "";
        foreach (char letter in text)
        {
            if (char.IsLetter(letter))
            {
                char decryptedLetter = (char)(letter - shift);
                if (char.IsUpper(letter) && decryptedLetter < 'A')
                {
                    decryptedLetter = (char)(decryptedLetter + 26);
                }
                else if (char.IsLower(letter) && decryptedLetter < 'a')
                {
                    decryptedLetter = (char)(decryptedLetter + 26);
                }
                decryptedText += decryptedLetter;
            }
            else
            {
                decryptedText += letter;
            }
        }
        return decryptedText;
    }

    static void Main()
    {
        Console.WriteLine("Enter text to encrypt:");
        string text = Console.ReadLine();

        Console.WriteLine("Enter shift value:");
        int shift = int.Parse(Console.ReadLine());

        string encryptedText = Encrypt(text, shift);
        Console.WriteLine("Encrypted text: " + encryptedText);

        string decryptedText = Decrypt(encryptedText, shift);
        Console.WriteLine("Decrypted text: " + decryptedText);
    }
}
