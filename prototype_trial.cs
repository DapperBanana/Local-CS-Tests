
using System;

class CaesarCipher
{
    static void Main()
    {
        Console.WriteLine("Enter text to encrypt:");
        string plaintext = Console.ReadLine();
        Console.WriteLine("Enter shift value:");
        int shift = int.Parse(Console.ReadLine());

        string ciphertext = Encrypt(plaintext, shift);
        Console.WriteLine("Encrypted text: " + ciphertext);

        string decryptedText = Decrypt(ciphertext, shift);
        Console.WriteLine("Decrypted text: " + decryptedText);
    }

    static string Encrypt(string plaintext, int shift)
    {
        string result = string.Empty;

        foreach (char c in plaintext)
        {
            if (char.IsLetter(c))
            {
                char offset = char.IsUpper(c) ? 'A' : 'a';
                result += (char)((((c + shift) - offset) % 26) + offset);
            }
            else
            {
                result += c;
            }
        }

        return result;
    }

    static string Decrypt(string ciphertext, int shift)
    {
        return Encrypt(ciphertext, 26 - shift);
    }
}
