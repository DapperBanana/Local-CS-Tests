
using System;
using System.Collections.Generic;

class RandomMazeGenerator
{
    private static int rows = 10;
    private static int cols = 10;
    private static char[,] maze = new char[rows, cols];
    private static Random rand = new Random();

    static void Main()
    {
        GenerateMaze();
        PrintMaze();
        FindSolution(0, 0);
        PrintMaze();
    }

    static void GenerateMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                maze[i, j] = rand.Next(2) == 0 ? '#' : ' ';
            }
        }
        maze[0, 0] = 'S'; // Start
        maze[rows - 1, cols - 1] = 'E'; // End
    }

    static void PrintMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(maze[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static bool FindSolution(int x, int y)
    {
        if (x < 0 || x >= rows || y < 0 || y >= cols || maze[x, y] == '#' || maze[x, y] == '*')
        {
            return false;
        }

        if (maze[x, y] == 'E')
        {
            return true;
        }

        maze[x, y] = '*'; // Mark as visited

        if (FindSolution(x + 1, y) || FindSolution(x, y + 1) || FindSolution(x - 1, y) || FindSolution(x, y - 1))
        {
            return true;
        }

        maze[x, y] = ' '; // Backtrack

        return false;
    }
}
