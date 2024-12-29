
using System;

class HangmanGame
{
    static void Main()
    {
        string secretWord = "hangman";
        int maxAttempts = 6;
        int attempts = 0;
        bool wordGuessed = false;
        bool[] letterGuessed = new bool[secretWord.Length];

        while (!wordGuessed && attempts < maxAttempts)
        {
            Console.WriteLine("Guess the word:");

            for (int i = 0; i < secretWord.Length; i++)
            {
                if (letterGuessed[i])
                {
                    Console.Write(secretWord[i] + " ");
                }
                else
                {
                    Console.Write("_ ");
                }
            }

            Console.WriteLine();
            Console.WriteLine("Attempts left: " + (maxAttempts - attempts));
            Console.Write("Enter a letter: ");
            char guess = Char.ToLower(Console.ReadLine()[0]);

            bool correctGuess = false;
            for (int i = 0; i < secretWord.Length; i++)
            {
                if (secretWord[i] == guess)
                {
                    letterGuessed[i] = true;
                    correctGuess = true;
                }
            }

            if (!correctGuess)
            {
                Console.WriteLine("Incorrect guess. Try again.");
                attempts++;
            }

            wordGuessed = true;
            foreach (bool letter in letterGuessed)
            {
                if (!letter)
                {
                    wordGuessed = false;
                    break;
                }
            }
        }

        if (wordGuessed)
        {
            Console.WriteLine("Congratulations! You guessed the word: " + secretWord);
        }
        else
        {
            Console.WriteLine("Out of attempts! The word was: " + secretWord);
        }
    }
}
