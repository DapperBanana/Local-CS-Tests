
using System;

class HangmanGame
{
    static void Main()
    {
        string[] words = { "hello", "world", "hangman", "programming", "computer" };
        Random random = new Random();
        string wordToGuess = words[random.Next(0, words.Length)];
        char[] guessedLetters = new char[wordToGuess.Length];
        int attempts = 6;
        bool wordGuessed = false;

        for (int i = 0; i < guessedLetters.Length; i++)
        {
            guessedLetters[i] = '_';
        }

        Console.WriteLine("Welcome to Hangman!");

        while (attempts > 0 && !wordGuessed)
        {
            Console.WriteLine("Word to guess: " + string.Join(" ", guessedLetters));
            Console.WriteLine("Attempts remaining: " + attempts);
            Console.Write("Enter a letter guess: ");
            char letterGuess = Console.ReadLine()[0];

            bool letterFound = false;

            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == letterGuess)
                {
                    guessedLetters[i] = letterGuess;
                    letterFound = true;
                }
            }

            if (!letterFound)
            {
                attempts--;
            }

            if (wordToGuess == string.Join("", guessedLetters))
            {
                wordGuessed = true;
            }
        }

        if (wordGuessed)
        {
            Console.WriteLine("Congratulations, you guessed the word: " + wordToGuess);
        }
        else
        {
            Console.WriteLine("Sorry, you ran out of attempts. The word was: " + wordToGuess);
        }
    }
}
