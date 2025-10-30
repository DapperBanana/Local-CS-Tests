
using System;

class HangmanGame
{
    private string word;
    private char[] guesses;
    private int remainingAttempts;

    public HangmanGame(string word, int attempts)
    {
        this.word = word.ToUpper();
        this.guesses = new char[word.Length];
        this.remainingAttempts = attempts;
    }

    public void PrintWord()
    {
        foreach (char c in guesses)
        {
            if (c == '\0')
            {
                Console.Write("_ ");
            }
            else
            {
                Console.Write(c + " ");
            }
        }
        Console.WriteLine();
    }

    public void Guess(char letter)
    {
        letter = Char.ToUpper(letter);

        if (word.Contains(letter))
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    guesses[i] = letter;
                }
            }
            Console.WriteLine("Correct guess!");
        }
        else
        {
            remainingAttempts--;
            Console.WriteLine("Incorrect guess. " + remainingAttempts + " attempts remaining.");
        }
    }

    public bool IsGameOver()
    {
        if (remainingAttempts <= 0)
        {
            Console.WriteLine("Game over. The word was: " + word);
            return true;
        }

        if (new string(guesses) == word)
        {
            Console.WriteLine("Congratulations! You guessed the word: " + word);
            return true;
        }

        return false;
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Let's play Hangman!");

        string wordToGuess = "elephant";
        int attempts = 7;

        HangmanGame hangman = new HangmanGame(wordToGuess, attempts);

        while (!hangman.IsGameOver())
        {
            Console.WriteLine();
            Console.WriteLine("Word to guess:");
            hangman.PrintWord();

            Console.Write("Enter a letter to guess: ");
            char guess = Console.ReadKey().KeyChar;
            Console.WriteLine();

            hangman.Guess(guess);
        }
    }
}
