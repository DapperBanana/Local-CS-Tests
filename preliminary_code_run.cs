
using System;
using System.Collections.Generic;

class MazeGenerator
{
    private int width;
    private int height;
    private char[,] maze;
    private Random random;

    public MazeGenerator(int width, int height)
    {
        this.width = width;
        this.height = height;
        maze = new char[width, height];
        random = new Random();
    }

    public void GenerateMaze()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                maze[i, j] = random.Next(10) < 3 ? '#' : ' ';
            }
        }
        maze[0, 0] = 'S';
        maze[width - 1, height - 1] = 'E';
    }

    public void PrintMaze()
    {
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < height; j++)
            {
                Console.Write(maze[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    public bool SolveMaze()
    {
        Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
        stack.Push(new Tuple<int, int>(0, 0));

        while (stack.Count > 0)
        {
            Tuple<int, int> current = stack.Pop();
            int x = current.Item1;
            int y = current.Item2;

            if (maze[x, y] == 'E')
            {
                return true;
            }

            maze[x, y] = '.';

            // Check for valid moves
            if (x > 0 && maze[x - 1, y] != '#' && maze[x - 1, y] != '.')
                stack.Push(new Tuple<int, int>(x - 1, y));

            if (x < width - 1 && maze[x + 1, y] != '#' && maze[x + 1, y] != '.')
                stack.Push(new Tuple<int, int>(x + 1, y));

            if (y > 0 && maze[x, y - 1] != '#' && maze[x, y - 1] != '.')
                stack.Push(new Tuple<int, int>(x, y - 1));

            if (y < height - 1 && maze[x, y + 1] != '#' && maze[x, y + 1] != '.')
                stack.Push(new Tuple<int, int>(x, y + 1));
        }

        return false;
    }
}

class Program
{
    static void Main()
    {
        MazeGenerator mg = new MazeGenerator(10, 10);
        mg.GenerateMaze();
        mg.PrintMaze();

        if (mg.SolveMaze())
        {
            Console.WriteLine("Maze solved!");
            mg.PrintMaze();
        }
        else
        {
            Console.WriteLine("Maze is unsolvable!");
        }
    }
}
