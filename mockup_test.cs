
using System;
using System.IO;

namespace MazeSolver
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] maze = File.ReadAllLines("maze.txt");
            int rows = maze.Length;
            int cols = maze[0].Length;

            int startX = 0;
            int startY = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (maze[i][j] == 'S')
                    {
                        startX = i;
                        startY = j;
                    }
                }
            }

            SolveMaze(maze, startX, startY);
        }

        static bool SolveMaze(string[] maze, int x, int y)
        {
            if (maze[x][y] == 'E')
            {
                return true;
            }

            if (maze[x][y] == '#' || maze[x][y] == 'V')
            {
                return false;
            }

            maze[x] = maze[x].Substring(0, y) + "V" + maze[x].Substring(y + 1);

            if (x > 0 && SolveMaze(maze, x - 1, y))
            {
                Console.WriteLine($"Move up to {x-1}, {y}");
                return true;
            }
            if (y < maze[0].Length - 1 && SolveMaze(maze, x, y + 1))
            {
                Console.WriteLine($"Move right to {x}, {y+1}");
                return true;
            }
            if (x < maze.Length - 1 && SolveMaze(maze, x + 1, y))
            {
                Console.WriteLine($"Move down to {x+1}, {y}");
                return true;
            }
            if (y > 0 && SolveMaze(maze, x, y - 1))
            {
                Console.WriteLine($"Move left to {x}, {y-1}");
                return true;
            }

            return false;
        }
    }
}
