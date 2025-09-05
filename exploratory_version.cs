
using System;
using System.Collections.Generic;

class Graph
{
    private int V; // No. of vertices
    private List<int>[] adj; // Adjacency List

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[V];
        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    public void BFS(int s, int d)
    {
        bool[] visited = new bool[V];
        int[] pred = new int[V];
        int[] dist = new int[V];

        for (int i = 0; i < V; i++)
        {
            dist[i] = int.MaxValue;
        }

        Queue<int> queue = new Queue<int>();

        visited[s] = true;
        dist[s] = 0;
        queue.Enqueue(s);

        while (queue.Count != 0)
        {
            int u = queue.Dequeue();

            foreach (var node in adj[u])
            {
                if (!visited[node])
                {
                    visited[node] = true;
                    dist[node] = dist[u] + 1;
                    pred[node] = u;
                    queue.Enqueue(node);

                    if(node == d)
                    {
                        PrintShortestPath(s, d, pred);
                        return;
                    }
                }
            }
        }

        Console.WriteLine("Shortest path does not exist.");
    }

    public void PrintShortestPath(int s, int d, int[] pred)
    {
        Console.Write("Shortest path from " + s + " to " + d + " : ");
        int x = d;
        while (x != s)
        {
            Console.Write(x + " ");
            x = pred[x];
        }
        Console.Write(s + "\n");
    }
}

class Program
{
    public static void Main()
    {
        Graph g = new Graph(4);
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 2);
        g.AddEdge(2, 0);
        g.AddEdge(2, 3);
        g.AddEdge(3, 3);

        int source = 0, dest = 3;
        g.BFS(source, dest);
    }
}
