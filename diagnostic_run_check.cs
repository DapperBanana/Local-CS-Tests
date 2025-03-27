
using System;

class HangmanGame
{
    static void Main()
    {
        string wordToGuess = "programming";
        char[] wordToGuessArray = wordToGuess.ToCharArray();
        char[] wordGuessed = new char[wordToGuess.Length];
        bool gameWon = false;

        for (int i = 0; i < wordGuessed.Length; i++)
        {
            wordGuessed[i] = '_';
        }

        while (!gameWon)
        {
            Console.WriteLine("Word to guess: {0}", String.Join(" ", wordGuessed));
            Console.Write("Enter a letter: ");
            char input = Char.ToLower(Console.ReadKey().KeyChar);

            bool letterFound = false;

            for (int i = 0; i < wordToGuessArray.Length; i++)
            {
                if (wordToGuessArray[i] == input)
                {
                    wordGuessed[i] = input;
                    letterFound = true;
                }
            }

            if (!letterFound)
            {
                Console.WriteLine("\nIncorrect guess. Try again!");
            }

            if (!wordGuessed.Contains('_'))
            {
                gameWon = true;
            }
        }

        Console.WriteLine("\nCongratulations! You guessed the word: {0}", wordToGuess);
    }
}
