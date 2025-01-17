
using System;
using System.Collections.Generic;

class Graph
{
    private readonly int V;
    private readonly List<Tuple<int, int>>[] adj;

    public Graph(int vertices)
    {
        V = vertices;
        adj = new List<Tuple<int, int>>[V];
        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<Tuple<int, int>>();
        }
    }

    public void AddEdge(int u, int v, int weight)
    {
        adj[u].Add(new Tuple<int, int>(v, weight));
        adj[v].Add(new Tuple<int, int>(u, weight));
    }

    public void Dijkstra(int src)
    {
        int[] dist = new int[V];
        bool[] visited = new bool[V];

        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
            visited[i] = false;
        }

        dist[src] = 0;

        for (int count = 0; count < V - 1; count++)
        {
            int u = MinDistance(dist, visited);
            visited[u] = true;

            foreach (var neighbor in adj[u])
            {
                int v = neighbor.Item1;
                int weight = neighbor.Item2;

                if (!visited[v] && dist[u] != int.MaxValue && dist[u] + weight < dist[v])
                {
                    dist[v] = dist[u] + weight;
                }
            }
        }

        PrintSolution(dist);
    }

    private int MinDistance(int[] dist, bool[] visited)
    {
        int min = int.MaxValue;
        int minIndex = -1;

        for (int v = 0; v < V; v++)
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
        for (int i = 0; i < V; i++)
        {
            Console.WriteLine(i + " \t " + dist[i]);
        }
    }

    public static void Main(string[] args)
    {
        Graph graph = new Graph(5);
        graph.AddEdge(0, 1, 10);
        graph.AddEdge(0, 2, 5);
        graph.AddEdge(1, 2, 2);
        graph.AddEdge(1, 3, 1);
        graph.AddEdge(2, 3, 9);
        graph.AddEdge(2, 4, 2);
        graph.AddEdge(3, 4, 4);

        graph.Dijkstra(0);
    }
}
