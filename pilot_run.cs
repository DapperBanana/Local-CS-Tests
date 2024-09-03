
using System;

class HangmanGame
{
    static void Main()
    {
        string secretWord = "programming";
        int maxGuesses = 6;
        int incorrectGuesses = 0;
        bool[] guessedLetters = new bool[secretWord.Length];

        Console.WriteLine("Welcome to Hangman!");

        while (incorrectGuesses < maxGuesses)
        {
            Console.WriteLine("\nSecret word: " + GetSecretWord(secretWord, guessedLetters));

            Console.Write("Enter a letter: ");
            char guess = Console.ReadKey().KeyChar;

            if (secretWord.Contains(guess))
            {
                Console.WriteLine("\nCorrect guess!");
                UpdateGuessedLetters(secretWord, guessedLetters, guess);
            }
            else
            {
                Console.WriteLine("\nIncorrect guess!");
                incorrectGuesses++;
            }

            if (IsWordGuessed(secretWord, guessedLetters))
            {
                Console.WriteLine("\nCongratulations! You guessed the word.");
                return;
            }
        }

        Console.WriteLine("\nGame over! The secret word was: " + secretWord);
    }

    static string GetSecretWord(string secretWord, bool[] guessedLetters)
    {
        string displayWord = "";
        for (int i = 0; i < secretWord.Length; i++)
        {
            if (guessedLetters[i])
            {
                displayWord += secretWord[i];
            }
            else
            {
                displayWord += "_";
            }
        }
        return displayWord;
    }

    static void UpdateGuessedLetters(string secretWord, bool[] guessedLetters, char guess)
    {
        for (int i = 0; i < secretWord.Length; i++)
        {
            if (secretWord[i] == guess)
            {
                guessedLetters[i] = true;
            }
        }
    }

    static bool IsWordGuessed(string secretWord, bool[] guessedLetters)
    {
        for (int i = 0; i < secretWord.Length; i++)
        {
            if (!guessedLetters[i])
            {
                return false;
            }
        }
        return true;
    }
}
