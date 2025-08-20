
using System;
using System.Collections.Generic;

public class Graph
{
    private int V; // Number of vertices
    private List<int>[] adj; // Adjacency list

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[V];
        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int u, int v)
    {
        adj[u].Add(v);
        adj[v].Add(u);
    }

    public void BFS(int source, int dest)
    {
        bool[] visited = new bool[V];
        int[] pred = new int[V];
        for (int i = 0; i < V; i++)
        {
            pred[i] = -1;
        }

        Queue<int> queue = new Queue<int>();
        visited[source] = true;
        queue.Enqueue(source);

        while (queue.Count > 0)
        {
            int u = queue.Dequeue();
            foreach (int v in adj[u])
            {
                if (!visited[v])
                {
                    visited[v] = true;
                    pred[v] = u;
                    queue.Enqueue(v);
                }
            }
        }

        if (!visited[dest])
        {
            Console.WriteLine("No path found from source to destination");
        }
        else
        {
            Console.Write("Shortest path: ");
            PrintPath(pred, source, dest);
        }
    }

    private void PrintPath(int[] pred, int source, int dest)
    {
        List<int> path = new List<int>();
        int u = dest;
        while (u != -1)
        {
            path.Add(u);
            u = pred[u];
        }

        path.Reverse();
        foreach (int v in path)
        {
            Console.Write($"{v} ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Graph graph = new Graph(8);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 3);
        graph.AddEdge(1, 2);
        graph.AddEdge(3, 4);
        graph.AddEdge(3, 7);
        graph.AddEdge(4, 5);
        graph.AddEdge(4, 6);
        graph.AddEdge(4, 7);
        graph.AddEdge(5, 6);
        graph.AddEdge(6, 7);

        int source = 0;
        int dest = 6;
        Console.WriteLine($"Shortest path from {source} to {dest}:");
        graph.BFS(source, dest);
    }
}
