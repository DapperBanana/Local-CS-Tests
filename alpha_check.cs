
using System;

class CaesarCipher
{
    public static string Encrypt(string text, int shift)
    {
        string result = "";
        foreach (char c in text)
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

    public static string Decrypt(string cipher, int shift)
    {
        return Encrypt(cipher, 26 - shift);
    }

    static void Main()
    {
        Console.Write("Enter text to encrypt: ");
        string text = Console.ReadLine();

        Console.Write("Enter shift value: ");
        int shift = int.Parse(Console.ReadLine());

        string encryptedText = Encrypt(text, shift);
        string decryptedText = Decrypt(encryptedText, shift);

        Console.WriteLine("Encrypted text: " + encryptedText);
        Console.WriteLine("Decrypted text: " + decryptedText);
    }
}
