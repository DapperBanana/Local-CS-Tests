
using System;

class CaesarCipher
{
    static void Main()
    {
        string inputText = "Hello, World!";
        int key = 3;

        string encryptedText = Encrypt(inputText, key);
        Console.WriteLine("Encrypted text: " + encryptedText);

        string decryptedText = Decrypt(encryptedText, key);
        Console.WriteLine("Decrypted text: " + decryptedText);
    }

    static string Encrypt(string text, int key)
    {
        string result = "";
        foreach (char character in text)
        {
            if (char.IsLetter(character))
            {
                char shiftedChar = (char)(((char.ToUpper(character) - 'A' + key) % 26) + 'A');
                result += char.IsLower(character) ? char.ToLower(shiftedChar) : shiftedChar;
            }
            else
            {
                result += character;
            }
        }
        return result;
    }

    static string Decrypt(string text, int key)
    {
        return Encrypt(text, 26 - key);
    }
}
