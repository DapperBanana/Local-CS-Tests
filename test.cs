
using System;

class HangmanGame
{
    static void Main()
    {
        string secretWord = "hello";
        int maxTries = 6;
        int currentTries = 0;
        bool[] guessedLetters = new bool[secretWord.Length];

        Console.WriteLine("Welcome to Hangman!");
        Console.WriteLine("Guess the word:");

        while (currentTries < maxTries)
        {
            bool wordGuessed = true;

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (guessedLetters[i])
                {
                    Console.Write(secretWord[i] + " ");
                }
                else
                {
                    Console.Write("_ ");
                    wordGuessed = false;
                }
            }

            if (wordGuessed)
            {
                Console.WriteLine("\nCongratulations! You've guessed the word!");
                break;
            }

            Console.WriteLine("\nEnter a letter:");
            char guess = Console.ReadLine()[0];

            bool found = false;
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == guess)
                {
                    guessedLetters[i] = true;
                    found = true;
                }
            }

            if (!found)
            {
                currentTries++;
                Console.WriteLine("Incorrect guess. Tries left: " + (maxTries - currentTries));
            }
        }

        if (currentTries == maxTries)
        {
            Console.WriteLine("\nOut of tries! The word was: " + secretWord);
        }

        Console.WriteLine("Game over. Thanks for playing!");
    }
}
