
using System;

class HangmanGame
{
    static void Main()
    {
        string secretWord = "programming";
        int maxAttempts = 6;
        int attempts = 0;
        bool solved = false;
        char[] guessedLetters = new char[secretWord.Length];

        Array.Fill(guessedLetters, '_');

        Console.WriteLine("Welcome to Hangman!");
        Console.WriteLine("Guess the word:");

        while (!solved && attempts < maxAttempts)
        {
            Console.WriteLine(string.Join(" ", guessedLetters));
            Console.WriteLine($"Attempts Left: {maxAttempts - attempts}");

            Console.Write("Enter a letter: ");
            char guess = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (secretWord.Contains(guess))
            {
                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (secretWord[i] == guess)
                    {
                        guessedLetters[i] = guess;
                    }
                }
            }
            else
            {
                attempts++;
            }

            if (string.Join("", guessedLetters) == secretWord)
            {
                solved = true;
            }
        }

        if (solved)
        {
            Console.WriteLine($"Congratulations! You guessed the word: {secretWord}");
        }
        else
        {
            Console.WriteLine($"Sorry, you ran out of attempts. The word was: {secretWord}");
        }
    }
}
