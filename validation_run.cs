
using System;
using System.Collections.Generic;

class MazeSolver
{
    static char[,] maze;
    static int rows, cols;
    static Random random = new Random();

    static void Main(string[] args)
    {
        rows = 10;
        cols = 10;
        maze = GenerateMaze();

        PrintMaze();
        SolveMaze();
        PrintMaze();
    }

    static char[,] GenerateMaze()
    {
        char[,] generatedMaze = new char[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                if (i == 0 || j == 0 || i == rows - 1 || j == cols - 1)
                {
                    generatedMaze[i, j] = '#';
                }
                else if (random.Next(2) == 0)
                {
                    generatedMaze[i, j] = '#';
                }
                else
                {
                    generatedMaze[i, j] = ' ';
                }
            }
        }

        generatedMaze[1, 0] = 'S';
        generatedMaze[rows - 2, cols - 1] = 'E';

        return generatedMaze;
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
        Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
        bool[,] visited = new bool[rows, cols];

        stack.Push(new Tuple<int, int>(1, 0));

        while (stack.Count > 0)
        {
            Tuple<int, int> current = stack.Pop();
            int x = current.Item1;
            int y = current.Item2;

            if (x < 0 || x >= rows || y < 0 || y >= cols || visited[x, y] || maze[x, y] == '#')
                continue;

            visited[x, y] = true;

            if (maze[x, y] == 'E')
            {
                Console.WriteLine("Found the exit!");
                break;
            }

            maze[x, y] = '.';
            stack.Push(new Tuple<int, int>(x + 1, y));
            stack.Push(new Tuple<int, int>(x - 1, y));
            stack.Push(new Tuple<int, int>(x, y + 1));
            stack.Push(new Tuple<int, int>(x, y - 1));

            PrintMaze();
        }
    }
}
