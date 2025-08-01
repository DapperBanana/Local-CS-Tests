
using System;

class MazeSolver
{
    static char[,] maze = new char[,]
    {
        { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
        { '#', 'S', ' ', ' ', '#', ' ', ' ', ' ', ' ', '#' },
        { '#', '#', '#', ' ', '#', ' ', '#', '#', ' ', '#' },
        { '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#' },
        { '#', '#', '#', '#', ' ', '#', '#', '#', ' ', '#' },
        { '#', ' ', ' ', ' ', ' ', '#', ' ', ' ', ' ', '#' },
        { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' }
    };

    static int startX = 1;
    static int startY = 1;

    static void SolveMaze(int x, int y)
    {
        if (maze[x, y] == 'E')
        {
            Console.WriteLine("Maze solved!");
            return;
        }

        if (maze[x, y] == '#' || maze[x, y] == '*')
            return;

        maze[x, y] = '*'; // mark current position as visited

        // move right
        SolveMaze(x + 1, y);

        // move left
        SolveMaze(x - 1, y);

        // move down
        SolveMaze(x, y + 1);

        // move up
        SolveMaze(x, y - 1);

        maze[x, y] = ' '; // reset current position
    }

    static void Main()
    {
        SolveMaze(startX, startY);

        Console.WriteLine("Could not solve maze.");
    }
}
