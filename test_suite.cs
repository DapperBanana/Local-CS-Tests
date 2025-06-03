
using System;
using System.Collections.Generic;

class Maze
{
    private readonly int _width;
    private readonly int _height;
    private readonly int[,] _maze;
    private readonly Random _random = new Random();

    public Maze(int width, int height)
    {
        _width = width;
        _height = height;
        _maze = new int[width, height];
        GenerateMaze();
    }

    private void GenerateMaze()
    {
        for (int x = 0; x < _width; x++)
        {
            for (int y = 0; y < _height; y++)
            {
                _maze[x, y] = _random.Next(2); // 0 means wall, 1 means path
            }
        }
        _maze[0, 0] = 1; // entrance
        _maze[_width - 1, _height - 1] = 1; // exit
    }

    public void PrintMaze()
    {
        for (int y = 0; y < _height; y++)
        {
            for (int x = 0; x < _width; x++)
            {
                Console.Write(_maze[x, y] == 0 ? "#" : " ");
            }
            Console.WriteLine();
        }
    }

    public bool SolveMaze()
    {
        bool[,] visited = new bool[_width, _height];
        Stack<(int, int)> stack = new Stack<(int, int)>();
        stack.Push((0, 0));

        while (stack.Count > 0)
        {
            var (x, y) = stack.Pop();

            if (x == _width - 1 && y == _height - 1)
            {
                return true; // maze solved
            }

            if (x < 0 || x >= _width || y < 0 || y >= _height || _maze[x, y] == 0 || visited[x, y])
            {
                continue;
            }

            visited[x, y] = true;

            stack.Push((x + 1, y));
            stack.Push((x - 1, y));
            stack.Push((x, y + 1));
            stack.Push((x, y - 1));
        }

        return false;
    }
}

class Program
{
    static void Main()
    {
        Maze maze = new Maze(10, 10);
        maze.PrintMaze();

        if (maze.SolveMaze())
        {
            Console.WriteLine("Maze solved!");
        }
        else
        {
            Console.WriteLine("Maze not solved.");
        }
    }
}
