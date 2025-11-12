
using System;

class HangmanGame
{
    static void Main()
    {
        string secretWord = "programming";
        char[] guessedWord = new char[secretWord.Length];

        for (int i = 0; i < secretWord.Length; i++)
        {
            guessedWord[i] = '-';
        }

        int tries = 6;

        while (tries > 0)
        {
            Console.WriteLine("Secret word: " + string.Join(" ", guessedWord));
            Console.WriteLine("Tries left: " + tries);

            Console.Write("Enter a letter: ");
            char input = char.Parse(Console.ReadLine());

            bool found = false;
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == input)
                {
                    guessedWord[i] = input;
                    found = true;
                }
            }

            if (!found)
            {
                tries--;
            }

            if (string.Join("", guessedWord) == secretWord)
            {
                Console.WriteLine("Congratulations! You guessed the word: " + secretWord);
                break;
            }
        }

        if (tries == 0)
        {
            Console.WriteLine("Out of tries! The secret word was: " + secretWord);
        }
    }
}
