
using System;
using System.Collections.Generic;

class Program
{
    static Random rand = new Random();
    static int height = 10;
    static int width = 10;
    static int[,] maze = new int[height, width];
    
    static void Main()
    {
        GenerateMaze();
        FindSolution();
        PrintMaze();
    }

    static void GenerateMaze()
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                maze[i, j] = rand.Next(2); // 0 for wall, 1 for path
            }
        }
    }

    static void FindSolution()
    {
        Stack<Tuple<int, int>> stack = new Stack<Tuple<int, int>>();
        stack.Push(new Tuple<int, int>(0, 0)); // Start at top left corner
        
        while (stack.Count > 0)
        {
            Tuple<int, int> current = stack.Peek();
            int x = current.Item1;
            int y = current.Item2;

            if (x == width - 1 && y == height - 1) // Reached the end
            {
                break;
            }

            maze[y, x] = 2; // Mark current position as visited

            // Try moving in all 4 directions
            if (x > 0 && maze[y, x - 1] == 1) stack.Push(new Tuple<int, int>(x - 1, y)); // Left
            else if (y > 0 && maze[y - 1, x] == 1) stack.Push(new Tuple<int, int>(x, y - 1)); // Up
            else if (x < width - 1 && maze[y, x + 1] == 1) stack.Push(new Tuple<int, int>(x + 1, y)); // Right
            else if (y < height - 1 && maze[y + 1, x] == 1) stack.Push(new Tuple<int, int>(x, y + 1)); // Down
            else stack.Pop(); // Dead end, backtrack
        }
    }

    static void PrintMaze()
    {
        for (int i = 0; i < height; i++)
        {
            for (int j = 0; j < width; j++)
            {
                switch (maze[i, j])
                {
                    case 0:
                        Console.Write("# ");
                        break;
                    case 1:
                        Console.Write("  ");
                        break;
                    case 2:
                        Console.Write("* ");
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}
