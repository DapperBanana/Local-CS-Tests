
using System;
using System.Collections.Generic;

class Maze
{
    private int[,] maze;
    private int rows;
    private int cols;
    private Random rand;

    public Maze(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        maze = new int[rows, cols];
        rand = new Random();
        GenerateMaze();
    }

    private void GenerateMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                maze[i, j] = rand.Next(2);
            }
        }
    }

    public void SolveMaze()
    {
        Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
        stack.Push(new Tuple<int, int>(0, 0));

        while (stack.Count > 0)
        {
            Tuple<int, int> current = stack.Pop();
            int row = current.Item1;
            int col = current.Item2;

            if (row < 0 || row >= rows || col < 0 || col >= cols || maze[row, col] == 1 || maze[row, col] == 2)
            {
                continue;
            }

            maze[row, col] = 2;

            if (row == rows - 1 && col == cols - 1)
            {
                break;
            }

            stack.Push(new Tuple<int, int>(row + 1, col));
            stack.Push(new Tuple<int, int>(row, col + 1));
            stack.Push(new Tuple<int, int>(row - 1, col));
            stack.Push(new Tuple<int, int>(row, col - 1));
        }

        if (maze[rows - 1, cols - 1] == 2)
        {
            Console.WriteLine("Maze Solved!");
        }
        else
        {
            Console.WriteLine("Maze cannot be solved.");
        }
    }

    public void PrintMaze()
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(maze[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main()
    {
        Maze maze = new Maze(5, 5);
        maze.PrintMaze();
        maze.SolveMaze();
    }
}
