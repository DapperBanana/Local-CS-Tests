
using System;

class CaesarCipher
{
    static void Main()
    {
        Console.WriteLine("Caesar Cipher Encryption and Decryption");

        Console.Write("Enter a string to encrypt: ");
        string plainText = Console.ReadLine();

        Console.Write("Enter the shift value: ");
        int shift = int.Parse(Console.ReadLine());

        string encryptedText = Encrypt(plainText, shift);
        Console.WriteLine($"Encrypted text: {encryptedText}");

        string decryptedText = Decrypt(encryptedText, shift);
        Console.WriteLine($"Decrypted text: {decryptedText}");
    }

    static string Encrypt(string text, int shift)
    {
        char[] charArray = text.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsLetter(charArray[i]))
            {
                charArray[i] = (char)(((charArray[i] - 'a' + shift) % 26) + 'a');
            }
        }

        return new string(charArray);
    }

    static string Decrypt(string text, int shift)
    {
        char[] charArray = text.ToCharArray();

        for (int i = 0; i < charArray.Length; i++)
        {
            if (char.IsLetter(charArray[i]))
            {
                charArray[i] = (char)(((charArray[i] - 'a' - shift + 26) % 26) + 'a');
            }
        }

        return new string(charArray);
    }
}
