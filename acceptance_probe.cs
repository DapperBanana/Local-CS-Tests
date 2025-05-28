
using System;
using System.Collections.Generic;

class Program
{
    static char[,] maze = {
        { '#', '#', '#', '#', '#', '#', '#', '#', '#'},
        { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#'},
        { '#', ' ', '#', ' ', '#', ' ', '#', '#', '#'},
        { '#', ' ', '#', ' ', '#', ' ', ' ', ' ', '#'},
        { '#', ' ', '#', '#', '#', '#', '#', ' ', '#'},
        { '#', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#'},
        { '#', '#', '#', '#', '#', '#', '#', ' ', '#'},
        { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        { '#', '#', '#', '#', '#', '#', '#', '#', '#'}
    };

    static int startRow = 1;
    static int startCol = 1;
    static int endRow = 7;
    static int endCol = 7;

    static void Main(string[] args)
    {
        bool[,] visited = new bool[maze.GetLength(0), maze.GetLength(1)];
        Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
        stack.Push(new Tuple<int, int>(startRow, startCol));

        while (stack.Count > 0)
        {
            var current = stack.Peek();
            int row = current.Item1;
            int col = current.Item2;

            if (row == endRow && col == endCol)
            {
                break;
            }

            visited[row, col] = true;

            // Try moving in different directions (up, down, left, right)
            if (row - 1 >= 0 && maze[row - 1, col] != '#' && !visited[row - 1, col])
            {
                stack.Push(new Tuple<int, int>(row - 1, col));
            }
            else if (col + 1 < maze.GetLength(1) && maze[row, col + 1] != '#' && !visited[row, col + 1])
            {
                stack.Push(new Tuple<int, int>(row, col + 1));
            }
            else if (row + 1 < maze.GetLength(0) && maze[row + 1, col] != '#' && !visited[row + 1, col])
            {
                stack.Push(new Tuple<int, int>(row + 1, col));
            }
            else if (col - 1 >= 0 && maze[row, col - 1] != '#' && !visited[row, col - 1])
            {
                stack.Push(new Tuple<int, int>(row, col - 1));
            }
            else
            {
                stack.Pop();
            }
        }

        if (stack.Count == 0)
        {
            Console.WriteLine("No solution found!");
        }
        else
        {
            Console.WriteLine("Solution found:");
            while (stack.Count > 0)
            {
                var point = stack.Pop();
                Console.WriteLine($"({point.Item1}, {point.Item2})");
            }
        }
    }
}
