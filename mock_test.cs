
using System;

class Hangman
{
    static void Main()
    {
        string[] words = { "apple", "banana", "cherry", "grape", "orange" };
        Random random = new Random();
        string wordToGuess = words[random.Next(words.Length)];
        char[] guessedWord = new char[wordToGuess.Length];

        for (int i = 0; i < wordToGuess.Length; i++)
        {
            guessedWord[i] = '_';
        }

        int attempts = 5;
        bool wordGuessed = false;

        while (attempts > 0 && !wordGuessed)
        {
            Console.WriteLine("Word to guess: " + String.Join(" ", guessedWord));

            Console.Write("Enter a letter: ");
            char letter = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            bool correctGuess = false;

            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == letter)
                {
                    guessedWord[i] = letter;
                    correctGuess = true;
                }
            }

            if (!correctGuess)
            {
                attempts--;
                Console.WriteLine("Incorrect guess! Attempts remaining: " + attempts);
            }

            if (String.Join("", guessedWord) == wordToGuess)
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
