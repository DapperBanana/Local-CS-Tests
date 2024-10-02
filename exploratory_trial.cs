
using System;
using System.Collections.Generic;

class Graph
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

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    public void BFS(int s, int d)
    {
        bool[] visited = new bool[V];
        int[] dist = new int[V];
        int[] pred = new int[V];
        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < V; i++)
        {
            visited[i] = false;
            dist[i] = int.MaxValue;
            pred[i] = -1;
        }

        visited[s] = true;
        dist[s] = 0;
        queue.Enqueue(s);

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

        if (!visited[d])
        {
            Console.WriteLine("Path does not exist.");
        }
        else
        {
            Console.Write("Shortest path from " + s + " to " + d + ": ");
            int crawl = d;
            Stack<int> path = new Stack<int>();
            path.Push(crawl);

            while (pred[crawl] != -1)
            {
                path.Push(pred[crawl]);
                crawl = pred[crawl];
            }

            while (path.Count != 0)
            {
                Console.Write(path.Pop() + " ");
            }
        }
    }

    public static void Main()
    {
        Graph g = new Graph(6);
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 3);
        g.AddEdge(2, 4);
        g.AddEdge(3, 5);
        g.AddEdge(4, 5);

        g.BFS(0, 5);
    }
}
