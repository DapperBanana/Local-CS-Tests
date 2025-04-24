
using System;

class Hangman
{
    static void Main()
    {
        string secretWord = "hangman";
        int maxAttempts = 6;
        int attempts = 0;
        char[] guessedWord = new char[secretWord.Length];

        for (int i = 0; i < secretWord.Length; i++)
        {
            guessedWord[i] = '_';
        }

        while (attempts < maxAttempts)
        {
            Console.WriteLine("Word: " + string.Join(" ", guessedWord));
            Console.WriteLine("Attempts left: " + (maxAttempts - attempts));
            Console.Write("Enter a letter: ");
            char guess = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            bool found = false;

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == guess)
                {
                    guessedWord[i] = guess;
                    found = true;
                }
            }

            if (!found)
            {
                attempts++;
            }

            if (guessedWord.SequenceEqual(secretWord.ToCharArray()))
            {
                Console.WriteLine("Congratulations! You guessed the word: " + secretWord);
                break;
            }
        }

        if (attempts == maxAttempts)
        {
            Console.WriteLine("Out of attempts! The word was: " + secretWord);
        }
    }
}
