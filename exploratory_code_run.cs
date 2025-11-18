
using System;

class HangmanGame
{
    static void Main()
    {
        string secretWord = "programming";
        char[] guessedLetters = new char[secretWord.Length];

        for (int i = 0; i < secretWord.Length; i++)
        {
            guessedLetters[i] = '_';
        }

        int attempts = 5;
        bool hasWon = false;

        while (attempts > 0)
        {
            Console.WriteLine("Secret Word: " + new string(guessedLetters));
            Console.WriteLine("Attempts Left: " + attempts);
            Console.WriteLine("Enter a letter: ");

            char guess = Console.ReadLine()[0];
            bool found = false;

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == guess)
                {
                    guessedLetters[i] = guess;
                    found = true;
                }
            }

            if (!found)
            {
                attempts--;
            }

            if (secretWord == new string(guessedLetters))
            {
                hasWon = true;
                break;
            }
        }

        if (hasWon)
        {
            Console.WriteLine("Congratulations! You guessed the word: " + secretWord);
        }
        else
        {
            Console.WriteLine("Out of attempts! The word was: " + secretWord);
        }
    }
}
