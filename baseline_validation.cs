
using System;
using System.Collections.Generic;

class MazeSolver
{
    private static int rows = 10;
    private static int cols = 10;
    private static char[,] maze = new char[rows, cols];

    static void Main(string[] args)
    {
        GenerateMaze();
        PrintMaze();
        SolveMaze(0, 0);
        Console.WriteLine("Solved Maze:");
        PrintMaze();
    }

    static void GenerateMaze()
    {
        Random rand = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                maze[i, j] = rand.Next(2) == 0 ? '#' : ' ';
            }
        }
        maze[0, 0] = 'S';
        maze[rows - 1, cols - 1] = 'E';
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
    }

    static bool SolveMaze(int row, int col)
    {
        if (row < 0 || row >= rows || col < 0 || col >= cols ||
            maze[row, col] == '#' || maze[row, col] == '.')
        {
            return false;
        }

        if (maze[row, col] == 'E')
        {
            return true;
        }

        maze[row, col] = '.';

        if (SolveMaze(row + 1, col) || SolveMaze(row - 1, col) ||
            SolveMaze(row, col + 1) || SolveMaze(row, col - 1))
        {
            return true;
        }

        maze[row, col] = ' ';
        return false;
    }
}
