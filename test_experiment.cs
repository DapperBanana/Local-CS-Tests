
using System;
using System.Collections.Generic;

class Maze
{
    private int width;
    private int height;
    private bool[,] visited;
    private int[,] maze;

    public Maze(int width, int height)
    {
        this.width = width;
        this.height = height;
        this.visited = new bool[height, width];
        this.maze = new int[height, width];
    }

    public void GenerateMaze()
    {
        Random random = new Random();

        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                maze[i, j] = random.Next(2);
            }
        }
    }

    public void PrintMaze()
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                Console.Write(maze[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public void SolveMaze(int startX, int startY, int endX, int endY)
    {
        Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();

        stack.Push(new Tuple<int, int>(startX, startY));

        while (stack.Count > 0)
        {
            Tuple<int, int> current = stack.Pop();
            int x = current.Item1;
            int y = current.Item2;

            if (x < 0 || x >= width || y < 0 || y >= height || visited[y, x] || maze[y, x] == 1)
            {
                continue;
            }

            visited[y, x] = true;

            if (x == endX && y == endY)
            {
                Console.WriteLine("Maze Solved!");
                return;
            }

            stack.Push(new Tuple<int, int>(x + 1, y));
            stack.Push(new Tuple<int, int>(x - 1, y));
            stack.Push(new Tuple<int, int>(x, y + 1));
            stack.Push(new Tuple<int, int>(x, y - 1));
        }

        Console.WriteLine("No solution found.");
    }
}

class Program
{
    static void Main()
    {
        Maze maze = new Maze(10, 10);
        maze.GenerateMaze();
        maze.PrintMaze();
        maze.SolveMaze(0, 0, 9, 9);
    }
}
