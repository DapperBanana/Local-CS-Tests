
using System;
using System.Collections.Generic;

class MazeGenerator
{
    private int height;
    private int width;
    private char[,] maze;
    private Random random = new Random();

    public MazeGenerator(int height, int width)
    {
        this.height = height;
        this.width = width;
        this.maze = new char[height, width];
    }

    public void GenerateMaze()
    {
        // Initialize maze with walls
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                maze[i, j] = '#';
            }
        }

        // Generate maze paths using depth-first search
        Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
        int x = random.Next(width);
        int y = random.Next(height);
        stack.Push(new Tuple<int, int>(x, y));

        while (stack.Count > 0)
        {
            Tuple<int, int> current = stack.Pop();
            x = current.Item1;
            y = current.Item2;

            if (maze[y, x] == '#')
            {
                maze[y, x] = ' ';
            }

            List<Tuple<int, int>> neighbors = GetNeighbors(x, y);
            Shuffle(neighbors);

            foreach (var neighbor in neighbors)
            {
                int nx = neighbor.Item1;
                int ny = neighbor.Item2;

                if (nx >= 0 && ny >= 0 && nx < width && ny < height && maze[ny, nx] == '#')
                {
                    stack.Push(new Tuple<int, int>(nx, ny));
                    maze[(y + ny) / 2, (x + nx) / 2] = ' ';
                }
            }
        }

        // Set entrance and exit of maze
        maze[1, 0] = ' ';
        maze[height - 2, width - 1] = ' ';
    }

    private List<Tuple<int, int>> GetNeighbors(int x, int y)
    {
        List<Tuple<int, int>> neighbors = new List<Tuple<int, int>>();
        neighbors.Add(new Tuple<int, int>(x - 2, y));
        neighbors.Add(new Tuple<int, int>(x + 2, y));
        neighbors.Add(new Tuple<int, int>(x, y - 2));
        neighbors.Add(new Tuple<int, int>(x, y + 2));
        return neighbors;
    }

    private void Shuffle(List<Tuple<int, int>> list)
    {
        for (int i = 0; i < list.Count; i++)
        {
            int j = random.Next(i, list.Count);
            Tuple<int, int> temp = list[i];
            list[i] = list[j];
            list[j] = temp;
        }
    }

    public void PrintMaze()
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

    public bool SolveMaze(int x, int y)
    {
        if (x < 0 || x >= width || y < 0 || y >= height)
        {
            return false;
        }

        if (maze[y, x] == '#')
        {
            return false;
        }

        if (maze[y, x] == 'E')
        {
            return true;
        }

        if (maze[y, x] == ' ')
        {
            maze[y, x] = 'X';

            if (SolveMaze(x + 1, y) || SolveMaze(x - 1, y) || SolveMaze(x, y + 1) || SolveMaze(x, y - 1))
            {
                return true;
            }

            maze[y, x] = ' ';
        }

        return false;
    }
}

class Program
{
    static void Main(string[] args)
    {
        int height = 15;
        int width = 15;

        MazeGenerator mazeGenerator = new MazeGenerator(height, width);
        mazeGenerator.GenerateMaze();
        mazeGenerator.PrintMaze();

        Console.WriteLine("Solving maze...");
        bool solved = mazeGenerator.SolveMaze(1, 1);

        if (solved)
        {
            Console.WriteLine("Maze solved:");
            mazeGenerator.PrintMaze();
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }
}
