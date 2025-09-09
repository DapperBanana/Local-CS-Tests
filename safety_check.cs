
using System;
using System.Collections.Generic;

class Program
{
    static int rows = 10;
    static int cols = 10;
    static char[,] maze = new char[rows, cols];
    static Random random = new Random();

    static void Main()
    {
        GenerateMaze();
        PrintMaze();

        bool[,] visited = new bool[rows, cols];
        bool foundExit = SolveMaze(0, 0, visited);
        
        if (foundExit)
        {
            Console.WriteLine("Maze successfully solved!");
            PrintMaze();
        }
        else
        {
            Console.WriteLine("Maze cannot be solved.");
        }
    }

    static void GenerateMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                maze[i, j] = random.Next(2) == 0 ? '#' : '.';
            }
        }

        maze[0, 0] = '.';
        maze[rows - 1, cols - 1] = '.';
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

    static bool SolveMaze(int row, int col, bool[,] visited)
    {
        if (row < 0 || col < 0 || row >= rows || col >= cols || maze[row, col] == '#' || visited[row, col])
        {
            return false;
        }

        visited[row, col] = true;

        if (row == rows - 1 && col == cols - 1)
        {
            return true;
        }

        if (SolveMaze(row + 1, col, visited) || SolveMaze(row - 1, col, visited) || SolveMaze(row, col + 1, visited) || SolveMaze(row, col - 1, visited))
        {
            maze[row, col] = '-';
            return true;
        }

        return false;
    }
}
