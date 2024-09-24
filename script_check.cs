
using System;
using System.Collections.Generic;

class Program
{
    static int mazeSize = 10;
    static char[,] maze = new char[mazeSize, mazeSize];
    static HashSet<(int, int)> visited = new HashSet<(int, int)>(); 

    static void Main()
    {
        GenerateMaze();
        PrintMaze();
        SolveMaze(0, 0);
    }

    static void GenerateMaze()
    {
        Random rand = new Random();
        for (int i = 0; i < mazeSize; i++)
        {
            for (int j = 0; j < mazeSize; j++)
            {
                if (rand.Next(2) == 0)
                {
                    maze[i, j] = 'X'; // Obstacle
                }
                else
                {
                    maze[i, j] = ' '; // Empty space
                }
            }
        }
        maze[0, 0] = 'S'; // Start
        maze[mazeSize - 1, mazeSize - 1] = 'E'; // End
    }

    static void PrintMaze()
    {
        for (int i = 0; i < mazeSize; i++)
        {
            for (int j = 0; j < mazeSize; j++)
            {
                Console.Write(maze[i, j]);
            }
            Console.WriteLine();
        }
    }

    static void SolveMaze(int x, int y)
    {
        if (x < 0 || y < 0 || x >= mazeSize || y >= mazeSize || maze[x, y] == 'X' || visited.Contains((x, y))) 
        {
            return;
        }

        visited.Add((x, y));

        if (maze[x, y] == 'E')
        {
            Console.WriteLine("Maze solved!");
            return;
        }

        maze[x, y] = '.';

        SolveMaze(x + 1, y); // Down
        SolveMaze(x - 1, y); // Up
        SolveMaze(x, y + 1); // Right
        SolveMaze(x, y - 1); // Left
    }
}
