
using System;
using System.Collections.Generic;

class MazeGenerator
{
    private int width;
    private int height;
    private char[,] maze;
    private Random rand;

    public MazeGenerator(int width, int height)
    {
        this.width = width;
        this.height = height;
        maze = new char[height, width];
        rand = new Random();
    }

    public void Generate()
    {
        // Initialize maze with walls
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                maze[i, j] = '#';
            }
        }

        // Create paths using depth-first search algorithm
        Stack<(int, int)> stack = new Stack<(int, int)>();
        stack.Push((1, 1));
        while (stack.Count > 0)
        {
            var current = stack.Pop();
            int x = current.Item1;
            int y = current.Item2;

            if (x < 1 || x >= width - 1 || y < 1 || y >= height - 1)
            {
                continue;
            }

            if (maze[y, x] == '#')
            {
                maze[y, x] = ' ';
                var directions = new List<(int, int)> { (-2, 0), (2, 0), (0, -2), (0, 2) };
                Shuffle(directions);
                foreach (var direction in directions)
                {
                    stack.Push((x + direction.Item1, y + direction.Item2));
                }
            }
        }

        // Set start and end points
        maze[1, 0] = 'S';
        maze[height - 2, width - 1] = 'E';
    }

    public void Solve()
    {
        int startX = 1;
        int startY = 0;
        Stack<(int, int)> stack = new Stack<(int, int)>();
        stack.Push((startX, startY));

        while (stack.Count > 0)
        {
            var current = stack.Pop();
            int x = current.Item1;
            int y = current.Item2;

            if (x < 1 || x >= width - 1 || y < 1 || y >= height - 1)
            {
                continue;
            }

            if (maze[y, x] != ' ' && maze[y, x] != 'S')
            {
                continue;
            }

            maze[y, x] = '.';

            var directions = new List<(int, int)> { (1, 0), (-1, 0), (0, 1), (0, -1) };
            Shuffle(directions);
            foreach (var direction in directions)
            {
                stack.Push((x + direction.Item1, y + direction.Item2));
            }
        }
    }

    public void Print()
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(maze[i, j]);
            }
            Console.WriteLine();
        }
    }

    private void Shuffle<T>(IList<T> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int j = rand.Next(i, list.Count);
            T temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }
}

class Program
{
    static void Main()
    {
        MazeGenerator maze = new MazeGenerator(21, 21);
        maze.Generate();
        maze.Print();

        Console.WriteLine();
        Console.WriteLine("Solving maze...");
        maze.Solve();
        maze.Print();
    }
}
