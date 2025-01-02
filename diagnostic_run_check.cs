
using System;
using System.Collections.Generic;

class Program
{
    static int rows = 10;
    static int cols = 10;
    static char[,] maze = new char[rows, cols];
    static bool[,] visited = new bool[rows, cols];

    static Random random = new Random();

    static void Main(string[] args)
    {
        GenerateMaze();
        PrintMaze();

        FindSolution(0, 0);
        Console.WriteLine();
        PrintMaze();
    }

    static void GenerateMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                maze[i, j] = random.Next(2) == 0 ? 'X' : ' ';
                visited[i, j] = false;
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
    }

    static bool FindSolution(int row, int col)
    {
        if (row < 0 || col < 0 || row >= rows || col >= cols || visited[row, col] || maze[row, col] == 'X')
            return false;

        visited[row, col] = true;

        if (maze[row, col] == 'E')
            return true;

        if (FindSolution(row - 1, col) ||
            FindSolution(row + 1, col) ||
            FindSolution(row, col - 1) ||
            FindSolution(row, col + 1))
        {
            maze[row, col] = '.';
            return true;
        }

        return false;
    }
}
