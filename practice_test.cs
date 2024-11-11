
using System;

class CaesarCipher
{
    static void Main()
    {
        Console.WriteLine("Enter text to encrypt:");
        string input = Console.ReadLine();
        
        Console.WriteLine("Enter the shift value (0-25):");
        int shift = Convert.ToInt32(Console.ReadLine());

        string encryptedText = Encrypt(input, shift);
        Console.WriteLine("Encrypted text: " + encryptedText);

        string decryptedText = Decrypt(encryptedText, shift);
        Console.WriteLine("Decrypted text: " + decryptedText);
    }

    static string Encrypt(string text, int shift)
    {
        char[] charArr = text.ToCharArray();
        for (int i = 0; i < charArr.Length; i++)
        {
            char letter = charArr[i];

            if (char.IsLetter(letter))
            {
                charArr[i] = (char)(((letter - 'A' + shift) % 26) + 'A');
            }
        }

        return new string(charArr);
    }

    static string Decrypt(string text, int shift)
    {
        char[] charArr = text.ToCharArray();
        for (int i = 0; i < charArr.Length; i++)
        {
            char letter = charArr[i];

            if (char.IsLetter(letter))
            {
                charArr[i] = (char)(((letter - 'A' - shift + 26) % 26) + 'A');
            }
        }

        return new string(charArr);
    }
}
