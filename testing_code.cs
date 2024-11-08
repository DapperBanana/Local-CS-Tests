
using System;
using System.Collections.Generic;

class Program
{
    static int[,] maze;
    static int rows, cols;

    static void Main()
    {
        rows = 10;
        cols = 10;

        GenerateMaze();
        PrintMaze();

        FindSolution();
    }

    static void GenerateMaze()
    {
        maze = new int[rows, cols];
        Random rand = new Random();

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
    }

    static void FindSolution()
    {
        bool[,] visited = new bool[rows, cols];
        Queue<(int, int)> queue = new Queue<(int, int)>();

        queue.Enqueue((0, 0));
        visited[0, 0] = true;

        while (queue.Count > 0)
        {
            var node = queue.Dequeue();
            int row = node.Item1;
            int col = node.Item2;

            if (row == rows - 1 && col == cols - 1)
            {
                Console.WriteLine("Solution found!");
                return;
            }

            // Check neighbors
            if (row - 1 >= 0 && maze[row - 1, col] == 1 && !visited[row - 1, col])
            {
                queue.Enqueue((row - 1, col));
                visited[row - 1, col] = true;
            }
            if (row + 1 < rows && maze[row + 1, col] == 1 && !visited[row + 1, col])
            {
                queue.Enqueue((row + 1, col));
                visited[row + 1, col] = true;
            }
            if (col - 1 >= 0 && maze[row, col - 1] == 1 && !visited[row, col - 1])
            {
                queue.Enqueue((row, col - 1));
                visited[row, col - 1] = true;
            }
            if (col + 1 < cols && maze[row, col + 1] == 1 && !visited[row, col + 1])
            {
                queue.Enqueue((row, col + 1));
                visited[row, col + 1] = true;
            }
        }

        Console.WriteLine("No solution found.");
    }
}
