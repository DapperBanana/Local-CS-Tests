
using System;

class Program
{
    static string Encrypt(string text, int shift)
    {
        char[] result = text.ToCharArray();

        for (int i = 0; i < result.Length; i++)
        {
            if (char.IsLetter(result[i]))
            {
                char offset = char.IsUpper(result[i]) ? 'A' : 'a';
                result[i] = (char)((((result[i] + shift) - offset) % 26) + offset);
            }
        }

        return new string(result);
    }

    static string Decrypt(string text, int shift)
    {
        return Encrypt(text, 26 - shift);
    }

    static void Main()
    {
        Console.Write("Enter text to encrypt: ");
        string input = Console.ReadLine();

        Console.Write("Enter shift value: ");
        int shift = int.Parse(Console.ReadLine());

        string encrypted = Encrypt(input, shift);

        Console.WriteLine($"Encrypted text: {encrypted}");

        string decrypted = Decrypt(encrypted, shift);

        Console.WriteLine($"Decrypted text: {decrypted}");
    }
}
