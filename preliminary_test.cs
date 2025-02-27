
using System;
using System.Collections.Generic;

class DijkstraAlgorithm
{
    static void Main()
    {
        int[,] graph = {
            {0, 3, 0, 0, 5},
            {3, 0, 4, 0, 0},
            {0, 4, 0, 7, 0},
            {0, 0, 7, 0, 2},
            {5, 0, 0, 2, 0}
        };

        FindShortestPath(graph, 0);
    }

    static void FindShortestPath(int[,] graph, int start)
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
                if (!visited[i] && graph[minIndex, i] != 0 && distances[minIndex] != int.MaxValue &&
                    distances[minIndex] + graph[minIndex, i] < distances[i])
                {
                    distances[i] = distances[minIndex] + graph[minIndex, i];
                }
            }
        }

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Shortest distance from node 0 to node {i} is: {distances[i]}");
        }
    }
}
