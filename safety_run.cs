
using System;

namespace HangmanGame
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretWord = "hello";
            char[] guessedWord = new char[secretWord.Length];

            for (int i = 0; i < secretWord.Length; i++)
            {
                guessedWord[i] = '_';
            }

            bool gameOver = false;
            int attempts = 6;

            while (!gameOver)
            {
                Console.WriteLine("Word: " + new string(guessedWord));
                Console.WriteLine("Attempts left: " + attempts);
                Console.Write("Guess a letter: ");
                char guess = Console.ReadLine()[0];

                bool letterFound = false;

                for (int i = 0; i < secretWord.Length; i++)
                {
                    if (secretWord[i] == guess)
                    {
                        guessedWord[i] = guess;
                        letterFound = true;
                    }
                }

                if (!letterFound)
                {
                    attempts--;
                    Console.WriteLine("Incorrect guess!");
                }

                if (attempts == 0)
                {
                    Console.WriteLine("You lose! The word was: " + secretWord);
                    gameOver = true;
                }

                if (new string(guessedWord) == secretWord)
                {
                    Console.WriteLine("Congratulations! You guessed the word!");
                    gameOver = true;
                }
            }
        }
    }
}
