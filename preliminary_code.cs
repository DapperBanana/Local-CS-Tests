
using System;

class HangmanGame
{
    static void Main()
    {
        string secretWord = "programming";
        string correctLetters = "";
        int tries = 6;

        Console.WriteLine("Welcome to Hangman!");
        Console.WriteLine("The secret word has " + secretWord.Length + " letters");

        while (tries > 0 && !IsWordGuessed(secretWord, correctLetters))
        {
            DisplayWord(secretWord, correctLetters);
            Console.WriteLine("You have " + tries + " tries left");
            char guessedLetter = GetGuess();
            if (secretWord.Contains(guessedLetter))
            {
                correctLetters += guessedLetter;
                Console.WriteLine("Good guess!");
            }
            else
            {
                tries--;
                Console.WriteLine("Wrong guess, try again");
            }
        }

        if (IsWordGuessed(secretWord, correctLetters))
        {
            Console.WriteLine("Congratulations! You guessed the word: " + secretWord);
        }
        else
        {
            Console.WriteLine("Sorry, you ran out of tries. The word was: " + secretWord);
        }
    }

    static void DisplayWord(string secretWord, string correctLetters)
    {
        foreach (char letter in secretWord)
        {
            if (correctLetters.Contains(letter))
            {
                Console.Write(letter + " ");
            }
            else
            {
                Console.Write("_ ");
            }
        }
        Console.WriteLine();
    }

    static char GetGuess()
    {
        Console.Write("Enter a letter: ");
        char letter = Console.ReadKey().KeyChar;
        Console.WriteLine();
        return letter;
    }

    static bool IsWordGuessed(string secretWord, string correctLetters)
    {
        foreach (char letter in secretWord)
        {
            if (!correctLetters.Contains(letter))
            {
                return false;
            }
        }
        return true;
    }
}
