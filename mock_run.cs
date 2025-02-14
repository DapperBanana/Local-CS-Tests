
using System;
using System.Collections.Generic;

class Graph
{
    private int vertices;
    private int[,] graph;

    public Graph(int v)
    {
        vertices = v;
        graph = new int[vertices, vertices];
    }

    public void AddEdge(int u, int v, int weight)
    {
        graph[u, v] = weight;
    }

    public void Dijkstra(int start)
    {
        int[] dist = new int[vertices];
        bool[] visited = new bool[vertices];

        for (int i = 0; i < vertices; i++)
        {
            dist[i] = int.MaxValue;
            visited[i] = false;
        }

        dist[start] = 0;

        for (int count = 0; count < vertices - 1; count++)
        {
            int u = MinDistance(dist, visited);
            visited[u] = true;

            for (int v = 0; v < vertices; v++)
            {
                if (!visited[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                {
                    dist[v] = dist[u] + graph[u, v];
                }
            }
        }

        PrintSolution(dist);
    }

    private int MinDistance(int[] dist, bool[] visited)
    {
        int min = int.MaxValue;
        int minIndex = -1;

        for (int v = 0; v < vertices; v++)
        {
            if (!visited[v] && dist[v] <= min)
            {
                min = dist[v];
                minIndex = v;
            }
        }

        return minIndex;
    }

    private void PrintSolution(int[] dist)
    {
        Console.WriteLine("Vertex \t Distance from Source");

        for (int i = 0; i < vertices; i++)
        {
            Console.WriteLine(i + " \t " + dist[i]);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Graph graph = new Graph(6);
        graph.AddEdge(0, 1, 4);
        graph.AddEdge(0, 2, 3);
        graph.AddEdge(1, 2, 1);
        graph.AddEdge(1, 3, 2);
        graph.AddEdge(2, 3, 4);
        graph.AddEdge(2, 4, 5);
        graph.AddEdge(3, 4, 1);
        graph.AddEdge(3, 5, 4);

        graph.Dijkstra(0);
    }
}
