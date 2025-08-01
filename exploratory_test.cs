
using System;
using System.Collections.Generic;

class MazeGenerator
{
    private int rows;
    private int cols;
    private bool[,] maze;

    public MazeGenerator(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        this.maze = new bool[rows, cols];
        GenerateMaze();
    }

    private void GenerateMaze()
    {
        Random rand = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                maze[i, j] = rand.Next(2) == 0 ? true : false;
            }
        }
    }

    public void PrintMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(maze[i, j] ? "# " : ". ");
            }
            Console.WriteLine();
        }
    }

    public bool SolveMaze()
    {
        bool[,] visited = new bool[rows, cols];
        Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
        stack.Push(new Tuple<int, int>(0, 0));

        while (stack.Count > 0)
        {
            Tuple<int, int> current = stack.Pop();

            if (current.Item1 == rows - 1 && current.Item2 == cols - 1)
            {
                return true;
            }

            visited[current.Item1, current.Item2] = true;

            List<Tuple<int, int>> neighbors = GetNeighbors(current.Item1, current.Item2, visited);

            foreach (var neighbor in neighbors)
            {
                stack.Push(neighbor);
            }
        }

        return false;
    }

    private List<Tuple<int, int>> GetNeighbors(int i, int j, bool[,] visited)
    {
        List<Tuple<int, int>> neighbors = new List<Tuple<int, int>>();

        if (i > 0 && !visited[i - 1, j] && maze[i - 1, j])
            neighbors.Add(new Tuple<int, int>(i - 1, j));
        if (i < rows - 1 && !visited[i + 1, j] && maze[i + 1, j])
            neighbors.Add(new Tuple<int, int>(i + 1, j));
        if (j > 0 && !visited[i, j - 1] && maze[i, j - 1])
            neighbors.Add(new Tuple<int, int>(i, j - 1));
        if (j < cols - 1 && !visited[i, j + 1] && maze[i, j + 1])
            neighbors.Add(new Tuple<int, int>(i, j + 1));

        return neighbors;
    }
}

class Program
{
    static void Main()
    {
        MazeGenerator maze = new MazeGenerator(5, 5);
        maze.PrintMaze();

        bool solved = maze.SolveMaze();

        if (solved)
        {
            Console.WriteLine("Maze solved!");
        }
        else
        {
            Console.WriteLine("Maze cannot be solved!");
        }
    }
}
