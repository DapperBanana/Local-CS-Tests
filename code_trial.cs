using System;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "computer", "programming", "hangman", "developer", "keyboard" };
            Random rand = new Random();
            string wordToGuess = words[rand.Next(words.Length)];
            char[] guessedLetters = new char[wordToGuess.Length];
            for (int i = 0; i < guessedLetters.Length; i++)
            {
                guessedLetters[i] = '_';
            }

            int maxAttempts = 6;
            int remainingAttempts = maxAttempts;
            string guessedLettersSet = "";

            Console.WriteLine("Welcome to Hangman!\n");

            while (remainingAttempts > 0 && new string(guessedLetters) != wordToGuess)
            {
                Console.WriteLine("Word to guess: " + string.Join(" ", guessedLetters));
                Console.WriteLine($"Remaining attempts: {remainingAttempts}");
                Console.Write("Guess a letter: ");
                string input = Console.ReadLine().ToLower();

                if (string.IsNullOrWhiteSpace(input) || input.Length != 1 || !Char.IsLetter(input[0]))
                {
                    Console.WriteLine("Please enter a valid single letter.\n");
                    continue;
                }

                char guessedChar = input[0];

                if (guessedLettersSet.Contains(guessedChar))
                {
                    Console.WriteLine("You already guessed that letter.\n");
                    continue;
                }

                guessedLettersSet += guessedChar;

                if (wordToGuess.Contains(guessedChar))
                {
                    for (int i = 0; i < wordToGuess.Length; i++)
                    {
                        if (wordToGuess[i] == guessedChar)
                        {
                            guessedLetters[i] = guessedChar;
                        }
                    }
                    Console.WriteLine("Correct!\n");
                }
                else
                {
                    remainingAttempts--;
                    Console.WriteLine("Incorrect!\n");
                }
            }

            if (new string(guessedLetters) == wordToGuess)
            {
                Console.WriteLine($"Congratulations! You guessed the word: {wordToGuess}");
            }
            else
            {
                Console.WriteLine($"Game Over! The word was: {wordToGuess}");
            }
        }
    }
}