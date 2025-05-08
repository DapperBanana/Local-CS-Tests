
using System;
using System.Collections.Generic;

class Program
{
    static int rows = 10;
    static int cols = 10;
    static int[,] maze = new int[rows, cols];
    static Random rand = new Random();

    static void Main()
    {
        GenerateMaze();
        PrintMaze();
        SolveMaze();
        PrintMaze();
    }

    static void GenerateMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                maze[i, j] = rand.Next(2);
            }
        }
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

    static void SolveMaze()
    {
        Stack<(int, int)> stack = new Stack<(int, int)>();
        bool[,] visited = new bool[rows, cols];

        stack.Push((0, 0));

        while (stack.Count > 0)
        {
            (int x, int y) = stack.Pop();

            if (x < 0 || y < 0 || x >= rows || y >= cols || maze[x, y] == 1 || visited[x, y])
            {
                continue;
            }

            visited[x, y] = true;

            if (x == rows - 1 && y == cols - 1)
            {
                return;
            }

            stack.Push((x + 1, y)); // down
            stack.Push((x, y + 1)); // right
            stack.Push((x - 1, y)); // up
            stack.Push((x, y - 1)); // left
        }
    }
}
