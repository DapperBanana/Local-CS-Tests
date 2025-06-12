
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int width = 10;
        int height = 10;

        int[,] maze = GenerateMaze(width, height);
        PrintMaze(maze);

        int startRow = 1;
        int startCol = 1;

        FindPath(maze, startRow, startCol);

        PrintMaze(maze);
    }

    static int[,] GenerateMaze(int width, int height)
    {
        Random rand = new Random();
        int[,] maze = new int[height, width];

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                maze[i, j] = (rand.Next(0, 2) == 1) ? 1 : 0;
            }
        }

        return maze;
    }

    static void PrintMaze(int[,] maze)
    {
        for (int i = 0; i < maze.GetLength(0); i++)
        {
            for (int j = 0; j < maze.GetLength(1); j++)
            {
                Console.Write(maze[i, j] + " ");
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }

    static bool FindPath(int[,] maze, int row, int col)
    {
        if (row < 0 || row >= maze.GetLength(0) || col < 0 || col >= maze.GetLength(1) || maze[row, col] == 1)
        {
            return false;
        }

        if (maze[row, col] == 2)
        {
            return false;
        }

        if (row == maze.GetLength(0) - 1 && col == maze.GetLength(1) - 1)
        {
            maze[row, col] = 2;
            return true;
        }

        maze[row, col] = 2;

        if (FindPath(maze, row + 1, col) || FindPath(maze, row - 1, col) || FindPath(maze, row, col + 1) || FindPath(maze, row, col - 1))
        {
            return true;
        }

        maze[row, col] = 0;
        return false;
    }
}
