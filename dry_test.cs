
using System;

class HangmanGame
{
    static void Main()
    {
        string secretWord = "programming";
        char[] guessedWord = new char[secretWord.Length];

        for (int i = 0; i < secretWord.Length; i++)
        {
            guessedWord[i] = '_';
        }

        int attempts = 0;

        while (attempts < secretWord.Length)
        {
            Console.WriteLine("Secret Word: " + string.Join(" ", guessedWord));

            Console.WriteLine("Enter a letter: ");
            char guess = Console.ReadLine()[0];

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
                Console.WriteLine("Incorrect guess. Try again.");
                attempts++;
            }

            bool gameWon = Array.IndexOf(guessedWord, '_') == -1;

            if (gameWon)
            {
                Console.WriteLine("Congratulations, you won! The secret word was: " + secretWord);
                break;
            }

            if (attempts >= secretWord.Length)
            {
                Console.WriteLine("You lose! The secret word was: " + secretWord);
                break;
            }
        }
    }
}
