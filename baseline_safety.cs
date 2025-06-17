
using System;

class CrosswordPuzzle
{
    static void Main()
    {
        // Define the size of the crossword puzzle
        int rows = 10;
        int cols = 10;

        // Create a 2D array to represent the crossword puzzle
        char[,] puzzle = new char[rows, cols];

        // Define the alphabet for filling the crossword puzzle
        char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

        // Fill the crossword puzzle with random characters from the alphabet
        Random rnd = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                puzzle[i, j] = alphabet[rnd.Next(alphabet.Length)];
            }
        }

        // Display the crossword puzzle
        Console.WriteLine("Crossword Puzzle:");
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(puzzle[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
