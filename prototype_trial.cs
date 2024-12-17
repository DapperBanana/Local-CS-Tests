
using System;
using System.Collections.Generic;

class Program
{
    static int rows = 10;
    static int cols = 10;
    static bool[,] maze = new bool[rows, cols];

    static void Main()
    {
        GenerateMaze();
        PrintMaze();

        FindPath();

        Console.WriteLine("\nSolved Maze:");
        PrintMaze();
    }

    static void GenerateMaze()
    {
        Random rand = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                maze[i, j] = rand.Next(100) < 30 ? true : false; // 30% chance of wall
            }
        }
        maze[0, 0] = false; // entrance
        maze[rows - 1, cols - 1] = false; // exit
    }

    static void PrintMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(maze[i, j] ? "# " : ". ");
            }
            Console.WriteLine();
        }
    }

    static void FindPath()
    {
        Stack<(int, int)> stack = new Stack<(int, int)>();
        bool[,] visited = new bool[rows, cols];

        stack.Push((0, 0));

        while (stack.Count > 0)
        {
            (int x, int y) = stack.Pop();

            if (x < 0 || x >= rows || y < 0 || y >= cols || maze[x, y] || visited[x, y])
                continue;

            visited[x, y] = true;

            if (x == rows - 1 && y == cols - 1) // reached the exit
                break;

            stack.Push((x + 1, y)); // down
            stack.Push((x - 1, y)); // up
            stack.Push((x, y + 1)); // right
            stack.Push((x, y - 1)); // left
        }

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (!visited[i, j] && !maze[i, j])
                {
                    maze[i, j] = true; // mark as not part of the solution path
                }
            }
        }
    }
}
