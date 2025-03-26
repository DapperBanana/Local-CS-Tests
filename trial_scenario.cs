
using System;
using System.Collections.Generic;

class Graph
{
    private int V; 
    private List<int>[] adj; 

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; ++i)
            adj[i] = new List<int>();
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    public void BFS(int s, int e)
    {
        bool[] visited = new bool[V];
        int[] pred = new int[V];
        for (int i = 0; i < V; ++i)
        {
            visited[i] = false;
            pred[i] = -1;
        }

        Queue<int> queue = new Queue<int>();

        visited[s] = true;
        queue.Enqueue(s);

        while (queue.Count != 0)
        {
            int curr = queue.Dequeue();

            if (curr == e)
                break;

            foreach (int next in adj[curr])
            {
                if (!visited[next])
                {
                    visited[next] = true;
                    queue.Enqueue(next);
                    pred[e] = curr;
                }
            }
        }

        PrintPath(pred, s, e);
    }

    private void PrintPath(int[] pred, int s, int e)
    {
        if (pred[e] == -1)
        {
            Console.WriteLine("No path exists from {0} to {1}", s, e);
            return;
        }

        Console.Write("Shortest path from {0} to {1}: ", s, e);

        List<int> path = new List<int>();
        for (int at = e; at != -1; at = pred[at])
        {
            path.Add(at);
        }

        path.Reverse();

        for (int i = 0; i < path.Count; ++i)
        {
            Console.Write(path[i] + " ");
        }
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

        Console.WriteLine("Shortest path using Breadth First Search:");
        g.BFS(2, 3);
    }
}
