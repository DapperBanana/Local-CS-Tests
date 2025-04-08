
using System;
using System.Collections.Generic;

class MazeSolver
{
    static int rows = 10;
    static int cols = 10;
    static int[,] maze = new int[rows, cols];

    static void GenerateMaze()
    {
        Random random = new Random();

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                maze[i, j] = random.Next(2);
            }
        }

        maze[0, 0] = 0; // start point
        maze[rows - 1, cols - 1] = 0; // end point
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

    static bool SolveMaze(int x, int y)
    {
        if (x < 0 || x >= rows || y < 0 || y >= cols)
        {
            return false;
        }

        if (maze[x, y] == 0)
        {
            maze[x, y] = 1;

            if (x == rows - 1 && y == cols - 1) // reached destination
            {
                return true;
            }

            if (SolveMaze(x + 1, y) || SolveMaze(x - 1, y) || SolveMaze(x, y + 1) || SolveMaze(x, y - 1))
            {
                return true;
            }

            maze[x, y] = 0; // backtrack
        }

        return false;
    }

    static void Main()
    {
        GenerateMaze();

        Console.WriteLine("Generated Maze:");
        PrintMaze();

        Console.WriteLine("Solving Maze:");
        if (SolveMaze(0, 0))
        {
            Console.WriteLine("Maze solved successfully!");
        }
        else
        {
            Console.WriteLine("Maze cannot be solved!");
        }

        Console.WriteLine("Final Maze:");
        PrintMaze();
    }
}
