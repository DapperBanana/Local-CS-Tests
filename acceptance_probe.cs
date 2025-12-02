using System;
using System.Collections.Generic;

class Hangman
{
    static void Main()
    {
        string[] words = { "computer", "programming", "hangman", "development", "software" };
        Random rand = new Random();
        string chosenWord = words[rand.Next(words.Length)];
        HashSet<char> guessedLetters = new HashSet<char>();
        int maxAttempts = 6;
        int attemptsLeft = maxAttempts;

        char[] displayedWord = new char[chosenWord.Length];
        for (int i = 0; i < chosenWord.Length; i++)
        {
            displayedWord[i] = '_';
        }

        Console.WriteLine("Welcome to Hangman!");

        while (attemptsLeft > 0 && Array.Exists(displayedWord, c => c == '_'))
        {
            Console.WriteLine("\nWord: " + String.Join(" ", displayedWord));
            Console.WriteLine("Attempts left: " + attemptsLeft);
            Console.Write("Guess a letter: ");
            string input = Console.ReadLine().ToLower();

            if (string.IsNullOrWhiteSpace(input) || input.Length != 1 || !char.IsLetter(input[0]))
            {
                Console.WriteLine("Please enter a single valid letter.");
                continue;
            }

            char guess = input[0];

            if (guessedLetters.Contains(guess))
            {
                Console.WriteLine("You've already guessed that letter. Try again.");
                continue;
            }

            guessedLetters.Add(guess);

            if (chosenWord.Contains(guess))
            {
                for (int i = 0; i < chosenWord.Length; i++)
                {
                    if (chosenWord[i] == guess)
                    {
                        displayedWord[i] = guess;
                    }
                }
                Console.WriteLine("Good guess!");
            }
            else
            {
                attemptsLeft--;
                Console.WriteLine("Wrong guess!");
            }
        }

        if (!Array.Exists(displayedWord, c => c == '_'))
        {
            Console.WriteLine($"\nCongratulations! You guessed the word: {chosenWord}");
        }
        else
        {
            Console.WriteLine($"\nGame over! The word was: {chosenWord}");
        }
        Console.WriteLine("Thanks for playing!");
    }
}