
using System;
using System.Collections.Generic;

class Program
{
    static int rows = 10;
    static int cols = 10;
    static int[,] maze = new int[rows, cols];
    static bool[,] visited = new bool[rows, cols];
    static int[,] directions = { { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 0 } };
    static Stack<(int, int)> stack = new Stack<(int, int)>();

    static void Main()
    {
        GenerateMaze();
        PrintMaze();
        FindPath();

        Console.WriteLine();
        PrintMaze();
    }

    static void GenerateMaze()
    {
        stack.Push((0, 0));
        visited[0, 0] = true;

        while (stack.Count > 0)
        {
            (int x, int y) = stack.Peek();
            List<int> neighbors = GetNeighbors(x, y);

            if (neighbors.Count == 0)
            {
                stack.Pop();
            }
            else
            {
                int nextIndex = neighbors[new Random().Next(neighbors.Count)];
                (int nx, int ny) = (x + directions[nextIndex, 0], y + directions[nextIndex, 1]);

                maze[x, y] |= 1 << nextIndex;
                maze[nx, ny] |= 1 << (nextIndex ^ 1);

                visited[nx, ny] = true;
                stack.Push((nx, ny));
            }
        }
    }

    static List<int> GetNeighbors(int x, int y)
    {
        List<int> neighbors = new List<int>();

        for (int i = 0; i < 4; i++)
        {
            int nx = x + directions[i, 0];
            int ny = y + directions[i, 1];

            if (nx >= 0 && ny >= 0 && nx < rows && ny < cols && !visited[nx, ny])
            {
                neighbors.Add(i);
            }
        }

        return neighbors;
    }

    static void FindPath()
    {
        stack.Clear();
        stack.Push((0, 0));

        while (stack.Count > 0)
        {
            (int x, int y) = stack.Pop();

            if (x == rows - 1 && y == cols - 1)
            {
                return;
            }

            for (int i = 0; i < 4; i++)
            {
                if ((maze[x, y] & 1 << i) == 0)
                {
                    int nx = x + directions[i, 0];
                    int ny = y + directions[i, 1];

                    if (nx >= 0 && ny >= 0 && nx < rows && ny < cols && !visited[nx, ny])
                    {
                        visited[nx, ny] = true;
                        stack.Push((nx, ny));
                    }
                }
            }
        }
    }

    static void PrintMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int cell = maze[i, j];

                if ((cell & 1) == 0)
                {
                    Console.Write("   ");
                }
                else
                {
                    Console.Write("   |");
                }
            }

            Console.WriteLine();

            for (int j = 0; j < cols; j++)
            {
                int cell = maze[i, j];

                if ((cell & 2) == 0)
                {
                    Console.Write("    ");
                }
                else
                {
                    Console.Write("----");
                }
            }

            Console.WriteLine();

            if (i == rows - 1)
            {
                for (int j = 0; j < cols; j++)
                {
                    int cell = maze[i, j];

                    if ((cell & 4) == 0)
                    {
                        Console.Write("   ");
                    }
                    else
                    {
                        Console.Write("   |");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
