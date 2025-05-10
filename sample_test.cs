
using System;

class HangmanGame
{
    static void Main()
    {
        string secretWord = "programming";
        char[] guessedWord = new char[secretWord.Length];

        for (int i = 0; i < secretWord.Length; i++)
        {
            guessedWord[i] = '_';
        }

        int attempts = 0;

        while (attempts < 6)
        {
            Console.WriteLine("Guessed Word: " + String.Join(" ", guessedWord));
            Console.WriteLine("Attempts left: " + (6 - attempts));
            Console.Write("Enter a letter: ");
            char letter = char.Parse(Console.ReadLine());

            bool found = false;

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == letter)
                {
                    guessedWord[i] = letter;
                    found = true;
                }
            }

            if (!found)
            {
                attempts++;
            }

            if (secretWord == String.Join("", guessedWord))
            {
                Console.WriteLine("Congratulations! You have guessed the word: " + secretWord);
                break;
            }
        }

        if (attempts >= 6)
        {
            Console.WriteLine("You have run out of attempts. The secret word was: " + secretWord);
        }
    }
}
