
using System;
using System.Collections.Generic;

class Graph
{
    private int V;
    private List<int>[] adj;

    public Graph(int vertices)
    {
        V = vertices;
        adj = new List<int>[V];
        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int u, int v)
    {
        adj[u].Add(v);
    }

    public void BreadthFirstSearch(int start, int end)
    {
        int[] pred = new int[V];
        int[] dist = new int[V];
        bool[] visited = new bool[V];

        Queue<int> queue = new Queue<int>();
        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
        }

        queue.Enqueue(start);
        visited[start] = true;
        dist[start] = 0;
        pred[start] = -1;

        while (queue.Count != 0)
        {
            int u = queue.Dequeue();
            foreach (int v in adj[u])
            {
                if (!visited[v])
                {
                    visited[v] = true;
                    dist[v] = dist[u] + 1;
                    pred[v] = u;
                    queue.Enqueue(v);
                }
            }
        }

        PrintPath(pred, start, end, dist[end]);
    }

    private void PrintPath(int[] pred, int start, int end, int dist)
    {
        if (dist == int.MaxValue)
        {
            Console.WriteLine("No path exists between start and end");
            return;
        }

        Console.WriteLine("Shortest path length is: " + dist);
        Console.Write("The path is: ");
        PrintPathUtil(pred, start, end);
        Console.WriteLine();
    }

    private void PrintPathUtil(int[] pred, int start, int end)
    {
        if (end == -1)
        {
            Console.Write(start + " ");
            return;
        }

        PrintPathUtil(pred, start, pred[end]);
        Console.Write(end + " ");
    }
}

class Program
{
    static void Main()
    {
        Graph graph = new Graph(6);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(2, 4);
        graph.AddEdge(3, 4);
        graph.AddEdge(4, 5);

        Console.WriteLine("Shortest path from node 0 to node 5:");
        graph.BreadthFirstSearch(0, 5);
    }
}
