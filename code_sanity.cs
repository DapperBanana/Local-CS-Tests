
using System;

class HangmanGame
{
    static void Main()
    {
        string secretWord = "hangman";
        string currentGuess = "";
        string guessedLetters = "";
        int attempts = 6;

        while (attempts > 0)
        {
            Console.WriteLine($"Attempts left: {attempts}");
            Console.WriteLine("Guessed letters: " + guessedLetters);
            Console.WriteLine("Current word: " + DisplayWord(secretWord, guessedLetters));

            Console.Write("Enter a letter: ");
            char input = Console.ReadLine()[0];

            if (guessedLetters.Contains(input))
            {
                Console.WriteLine("You've already guessed that letter!");
                continue;
            }

            guessedLetters += input;

            if (!secretWord.Contains(input))
            {
                attempts--;
            }

            if (DisplayWord(secretWord, guessedLetters) == secretWord)
            {
                Console.WriteLine($"Congratulations! You've guessed the word \"{secretWord}\"!");
                break;
            }
        }

        if (attempts == 0)
        {
            Console.WriteLine("You're out of attempts! The word was \"" + secretWord + "\"");
        }
    }

    static string DisplayWord(string secretWord, string guessedLetters)
    {
        string display = "";
        foreach (char letter in secretWord)
        {
            if (guessedLetters.Contains(letter))
            {
                display += letter;
            }
            else
            {
                display += "_";
            }
        }
        return display;
    }
}
