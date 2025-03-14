
using System;

namespace RandomCrosswordGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Define the size of the crossword puzzle
            int rows = 10;
            int cols = 10;

            // Create a random number generator
            Random rand = new Random();

            // Create a 2D array to store the crossword puzzle
            char[,] crossword = new char[rows, cols];

            // Generate random letters for the crossword puzzle
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    crossword[i, j] = (char)('A' + rand.Next(26));
                }
            }

            // Print the crossword puzzle
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(crossword[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
