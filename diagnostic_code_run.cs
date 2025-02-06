
using System;
using System.Collections.Generic;

class Maze
{
    private int width;
    private int height;
    private bool[,] grid;
    private bool[,] visited;

    public Maze(int width, int height)
    {
        this.width = width;
        this.height = height;
        grid = new bool[width, height];
        visited = new bool[width, height];
    }

    public void GenerateMaze()
    {
        Random rand = new Random();
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                grid[x, y] = rand.Next(2) == 0 ? true : false;
                visited[x, y] = false;
            }
        }
    }

    public void SolveMaze()
    {
        Stack<(int, int)> stack = new Stack<(int, int)>();
        stack.Push((0, 0));

        while (stack.Count > 0)
        {
            var (x, y) = stack.Pop();

            if (x < 0 || x >= width || y < 0 || y >= height || visited[x, y])
                continue;

            visited[x, y] = true;

            if (x == width - 1 && y == height - 1)
            {
                Console.WriteLine("Maze Solved!");
                return;
            }

            if (x + 1 < width && grid[x + 1, y])
                stack.Push((x + 1, y));

            if (x - 1 >= 0 && grid[x - 1, y])
                stack.Push((x - 1, y));

            if (y + 1 < height && grid[x, y + 1])
                stack.Push((x, y + 1));

            if (y - 1 >= 0 && grid[x, y - 1])
                stack.Push((x, y - 1));
        }

        Console.WriteLine("No solution found!");
    }

    public void PrintMaze()
    {
        for (int y = 0; y < height; y++)
        {
            for (int x = 0; x < width; x++)
            {
                Console.Write(grid[x, y] ? "O " : ". ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    public static void Main()
    {
        Maze maze = new Maze(10, 10);
        maze.GenerateMaze();
        maze.PrintMaze();
        maze.SolveMaze();
    }
}
