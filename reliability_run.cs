
using System;
using System.Collections.Generic;

class MazeGenerator
{
    private int[,] maze;
    private int width;
    private int height;
    private Random random;

    public MazeGenerator(int width, int height)
    {
        this.width = width;
        this.height = height;
        this.random = new Random();
        this.maze = new int[width, height];
        GenerateMaze();
    }

    private void GenerateMaze()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                maze[i, j] = 1;
            }
        }

        for (int i = 1; i < width; i += 2)
        {
            for (int j = 1; j < height; j += 2)
            {
                maze[i, j] = 0;
            }
        }

        Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
        stack.Push(new Tuple<int, int>(1, 1));

        while (stack.Count > 0)
        {
            var current = stack.Peek();
            List<Tuple<int, int>> neighbors = GetNeighbors(current.Item1, current.Item2);
            if (neighbors.Count == 0)
            {
                stack.Pop();
            }
            else
            {
                var randomIndex = random.Next(neighbors.Count);
                var neighbor = neighbors[randomIndex];
                int x = (current.Item1 + neighbor.Item1) / 2;
                int y = (current.Item2 + neighbor.Item2) / 2;
                maze[x, y] = 0;
                maze[neighbor.Item1, neighbor.Item2] = 0;
                stack.Push(neighbor);
            }
        }
    }

    private List<Tuple<int, int>> GetNeighbors(int x, int y)
    {
        List<Tuple<int, int>> neighbors = new List<Tuple<int, int>>();

        if (x - 2 >= 0) neighbors.Add(new Tuple<int, int>(x - 2, y));
        if (x + 2 < width) neighbors.Add(new Tuple<int, int>(x + 2, y));
        if (y - 2 >= 0) neighbors.Add(new Tuple<int, int>(x, y - 2));
        if (y + 2 < height) neighbors.Add(new Tuple<int, int>(x, y + 2));

        return neighbors;
    }

    public void PrintMaze()
    {
        for (int j = 0; j < height; j++)
        {
            for (int i = 0; i < width; i++)
            {
                if (maze[i, j] == 1)
                {
                    Console.Write("#");
                }
                else
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        MazeGenerator mazeGenerator = new MazeGenerator(21, 21);
        mazeGenerator.PrintMaze();
    }
}
