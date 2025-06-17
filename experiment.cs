
using System;

class Program
{
    static char[,] maze = new char[,]
    {
        { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
        { '#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#' },
        { '#', '#', '#', ' ', '#', '#', ' ', '#', ' ', '#' },
        { '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#' },
        { '#', ' ', '#', '#', '#', '#', ' ', ' ', ' ', '#' },
        { '#', ' ', ' ', ' ', ' ', ' ', '#', '#', ' ', '#' },
        { '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#' },
        { '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
        { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
    };

    static int startX = 1;
    static int startY = 1;
    static int endX = 7;
    static int endY = 7;

    static void Main()
    {
        if (SolveMaze(startX, startY))
        {
            PrintMaze();
        }
        else
        {
            Console.WriteLine("No solution found.");
        }
    }

    static bool SolveMaze(int x, int y)
    {
        if (x < 0 || x >= maze.GetLength(0) || y < 0 || y >= maze.GetLength(1) || maze[x, y] == '#' || maze[x, y] == '*')
        {
            return false;
        }

        if (x == endX && y == endY)
        {
            maze[x, y] = '*';
            return true;
        }

        maze[x, y] = '*';

        if (SolveMaze(x + 1, y) || SolveMaze(x - 1, y) || SolveMaze(x, y + 1) || SolveMaze(x, y - 1))
        {
            return true;
        }

        maze[x, y] = ' ';
        return false;
    }

    static void PrintMaze()
    {
        for (int i = 0; i < maze.GetLength(0); i++)
        {
            for (int j = 0; j < maze.GetLength(1); j++)
            {
                Console.Write(maze[i, j]);
            }
            Console.WriteLine();
        }
    }
}
