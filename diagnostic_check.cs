
using System;

class CaesarCipher
{
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

    static string Encrypt(string text, int shift)
    {
        char[] characters = text.ToCharArray();

        for (int i = 0; i < characters.Length; i++)
        {
            char character = characters[i];

            // Encrypt only alphabetical characters
            if (char.IsLetter(character))
            {
                char shiftedCharacter = (char)(character + shift);

                if (char.IsUpper(character))
                {
                    if (shiftedCharacter > 'Z')
                    {
                        shiftedCharacter = (char)(shiftedCharacter - 26);
                    }
                    else if (shiftedCharacter < 'A')
                    {
                        shiftedCharacter = (char)(shiftedCharacter + 26);
                    }
                }
                else
                {
                    if (shiftedCharacter > 'z')
                    {
                        shiftedCharacter = (char)(shiftedCharacter - 26);
                    }
                    else if (shiftedCharacter < 'a')
                    {
                        shiftedCharacter = (char)(shiftedCharacter + 26);
                    }
                }

                characters[i] = shiftedCharacter;
            }
        }

        return new string(characters);
    }

    static string Decrypt(string text, int shift)
    {
        return Encrypt(text, -shift);
    }
}
