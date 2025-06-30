
using System;

class HangmanGame
{
    static void Main()
    {
        string secretWord = "hangman";
        char[] guessedWord = new char[secretWord.Length];

        for (int i = 0; i < guessedWord.Length; i++)
        {
            guessedWord[i] = '_';
        }

        int attempts = 6;
        bool wordGuessed = false;

        while (attempts > 0 && !wordGuessed)
        {
            Console.WriteLine("Word: " + string.Join(" ", guessedWord));
            Console.WriteLine("Attempts left: " + attempts);
            Console.WriteLine("Enter a letter: ");
            char letter = char.Parse(Console.ReadLine());

            bool letterFound = false;

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == letter)
                {
                    guessedWord[i] = letter;
                    letterFound = true;
                }
            }

            if (!letterFound)
            {
                attempts--;
            }

            if (new string(guessedWord) == secretWord)
            {
                wordGuessed = true;
            }
        }

        if (wordGuessed)
        {
            Console.WriteLine("Congratulations! You've guessed the word: " + secretWord);
        }
        else
        {
            Console.WriteLine("You've run out of attempts. The word was: " + secretWord);
        }
    }
}
