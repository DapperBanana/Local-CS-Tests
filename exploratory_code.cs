
using System;

class HangmanGame
{
    static void Main()
    {
        string secretWord = "programming";
        int maxGuesses = 6;
        int remainingGuesses = maxGuesses;
        bool gameWon = false;
        char[] guessedLetters = new char[secretWord.Length];

        Console.WriteLine("Welcome to Hangman!");
        Console.WriteLine("Try to guess the secret word.");

        while (remainingGuesses > 0 && !gameWon)
        {
            Console.WriteLine("\nSecret word: " + DisplayWord(secretWord, guessedLetters));
            Console.WriteLine("Remaining guesses: " + remainingGuesses);

            Console.Write("Enter a letter guess: ");
            char guess = Console.ReadLine()[0];

            if (IsLetterInWord(guess, secretWord, guessedLetters))
            {
                Console.WriteLine("Correct!");
                if (IsWordGuessed(secretWord, guessedLetters))
                {
                    gameWon = true;
                }
            }
            else
            {
                Console.WriteLine("Incorrect guess.");
                remainingGuesses--;
            }
        }

        if (gameWon)
        {
            Console.WriteLine("Congratulations, you guessed the secret word: " + secretWord);
        }
        else
        {
            Console.WriteLine("Sorry, you ran out of guesses. The secret word was: " + secretWord);
        }
    }

    static bool IsLetterInWord(char letter, string word, char[] guessedLetters)
    {
        bool isLetterInWord = false;
        for (int i = 0; i < word.Length; i++)
        {
            if (word[i] == letter)
            {
                guessedLetters[i] = letter;
                isLetterInWord = true;
            }
        }
        return isLetterInWord;
    }

    static string DisplayWord(string word, char[] guessedLetters)
    {
        string display = "";
        for (int i = 0; i < word.Length; i++)
        {
            if (guessedLetters[i] == 0)
            {
                display += "_";
            }
            else
            {
                display += guessedLetters[i];
            }
        }
        return display;
    }

    static bool IsWordGuessed(string word, char[] guessedLetters)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (guessedLetters[i] == 0)
            {
                return false;
            }
        }
        return true;
    }
}
