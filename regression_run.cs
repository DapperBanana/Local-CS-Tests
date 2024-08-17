
using System;
using System.Collections.Generic;

class DijkstraAlgorithm
{
    static int[] Dijkstra(int[,] graph, int start)
    {
        int n = graph.GetLength(0);
        int[] distances = new int[n];
        bool[] visited = new bool[n];

        for (int i = 0; i < n; i++)
        {
            distances[i] = int.MaxValue;
            visited[i] = false;
        }

        distances[start] = 0;

        for (int count = 0; count < n - 1; count++)
        {
            int minDistance = int.MaxValue;
            int minIndex = -1;

            for (int i = 0; i < n; i++)
            {
                if (!visited[i] && distances[i] < minDistance)
                {
                    minDistance = distances[i];
                    minIndex = i;
                }
            }

            visited[minIndex] = true;

            for (int i = 0; i < n; i++)
            {
                if (!visited[i] && graph[minIndex, i] != 0 &&
                    distances[minIndex] != int.MaxValue &&
                    distances[minIndex] + graph[minIndex, i] < distances[i])
                {
                    distances[i] = distances[minIndex] + graph[minIndex, i];
                }
            }
        }

        return distances;
    }

    static void Main()
    {
        int[,] graph = {
            {0, 4, 0, 0, 0, 0, 0, 8, 0},
            {4, 0, 8, 0, 0, 0, 0, 11, 0},
            {0, 8, 0, 7, 0, 4, 0, 0, 2},
            {0, 0, 7, 0, 9, 14, 0, 0, 0},
            {0, 0, 0, 9, 0, 10, 0, 0, 0},
            {0, 0, 4, 14, 10, 0, 2, 0, 0},
            {0, 0, 0, 0, 0, 2, 0, 1, 6},
            {8, 11, 0, 0, 0, 0, 1, 0, 7},
            {0, 0, 2, 0, 0, 0, 6, 7, 0}
        };

        int start = 0;
        int[] distances = Dijkstra(graph, start);

        Console.WriteLine("Shortest distances from node 0:");

        for (int i = 0; i < distances.Length; i++)
        {
            Console.WriteLine($"Node {i}: {distances[i]}");
        }
    }
}
