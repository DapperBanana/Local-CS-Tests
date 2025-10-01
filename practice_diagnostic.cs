
using System;

class HangmanGame
{
    static void Main()
    {
        string[] words = { "computer", "programming", "hangman", "software", "debugging" };

        Random random = new Random();
        string wordToGuess = words[random.Next(words.Length)];
        char[] guess = new char[wordToGuess.Length];

        for (int i = 0; i < guess.Length; i++)
        {
            guess[i] = '_';
        }

        int attempts = 10;
        bool wordGuessed = false;

        while (attempts > 0 && !wordGuessed)
        {
            Console.WriteLine("Word to guess: " + String.Join(" ", guess));
            Console.WriteLine("Attempts left: " + attempts);

            Console.Write("Enter a letter to guess: ");
            char letter = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            bool foundLetter = false;

            for (int i = 0; i < wordToGuess.Length; i++)
            {
                if (wordToGuess[i] == letter)
                {
                    guess[i] = letter;
                    foundLetter = true;
                }
            }

            if (!foundLetter)
            {
                attempts--;
            }

            if (new string(guess) == wordToGuess)
            {
                wordGuessed = true;
                Console.WriteLine("Congratulations! You guessed the word: " + wordToGuess);
            }
        }

        if (!wordGuessed)
        {
            Console.WriteLine("Sorry, you ran out of attempts. The word was: " + wordToGuess);
        }
    }
}
