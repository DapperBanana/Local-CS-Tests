
using System;

class Program
{
    static char[,] maze =
    {
        {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
        {'#', ' ', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#'},
        {'#', '#', '#', ' ', '#', ' ', '#', '#', ' ', '#'},
        {'#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#'},
        {'#', ' ', '#', '#', '#', '#', ' ', ' ', ' ', '#'},
        {'#', ' ', ' ', ' ', ' ', '#', ' ', '#', '#', '#'},
        {'#', ' ', '#', '#', ' ', '#', ' ', ' ', ' ', '#'},
        {'#', ' ', ' ', '#', ' ', ' ', ' ', '#', ' ', '#'},
        {'#', '#', ' ', '#', '#', '#', ' ', '#', ' ', '#'},
        {'#', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
        {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
    };

    static int startX = 1;
    static int startY = 1;
    static int endX = 8;
    static int endY = 8;

    static void Main()
    {
        SolveMaze(startX, startY);
    }

    static bool SolveMaze(int x, int y)
    {
        if (x == endX && y == endY)
        {
            PrintMaze();
            return true;
        }

        if (maze[y, x] == '#')
        {
            return false;
        }

        maze[y, x] = 'X';

        if (SolveMaze(x + 1, y) || SolveMaze(x - 1, y) || SolveMaze(x, y + 1) || SolveMaze(x, y - 1))
        {
            return true;
        }

        maze[y, x] = ' ';
        return false;
    }

    static void PrintMaze()
    {
        for (int i = 0; i < maze.GetLength(0); i++)
        {
            for (int j = 0; j < maze.GetLength(1); j++)
            {
                Console.Write(maze[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
