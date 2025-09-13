
using System;

class CaesarCipher
{
    static void Main()
    {
        Console.WriteLine("Enter a string to encrypt:");
        string plainText = Console.ReadLine();

        Console.WriteLine("Enter the encryption key:");
        int key = int.Parse(Console.ReadLine());

        string cipherText = Encrypt(plainText, key);
        Console.WriteLine("Encrypted text: " + cipherText);

        string decryptedText = Decrypt(cipherText, key);
        Console.WriteLine("Decrypted text: " + decryptedText);
    }

    public static string Encrypt(string input, int key)
    {
        string result = "";

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char shiftedChar = (char)((c + key - 'a') % 26 + 'a');
                result += shiftedChar;
            }
            else
            {
                result += c;
            }
        }

        return result;
    }

    public static string Decrypt(string input, int key)
    {
        string result = "";

        foreach (char c in input)
        {
            if (char.IsLetter(c))
            {
                char shiftedChar = (char)((c - key - 'a' + 26) % 26 + 'a');
                result += shiftedChar;
            }
            else
            {
                result += c;
            }
        }

        return result;
    }
}
