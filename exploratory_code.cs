
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
        for (int i = 0; i < v; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    public List<int> ShortestPath(int s, int d)
    {
        List<int> shortestPath = new List<int>();

        Queue<List<int>> queue = new Queue<List<int>>();
        List<int> path = new List<int>();
        path.Add(s);
        queue.Enqueue(path);

        while (queue.Count != 0)
        {
            path = queue.Dequeue();
            int lastVertex = path[path.Count - 1];

            if (lastVertex == d)
            {
                shortestPath = path;
                break;
            }

            foreach (var adjacent in adj[lastVertex])
            {
                if (!path.Contains(adjacent))
                {
                    List<int> newPath = new List<int>(path);
                    newPath.Add(adjacent);
                    queue.Enqueue(newPath);
                }
            }
        }

        return shortestPath;
    }
}

class Program
{
    public static void Main(string[] args)
    {
        Graph g = new Graph(4);
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 2);
        g.AddEdge(2, 0);
        g.AddEdge(2, 3);
        g.AddEdge(3, 3);

        List<int> shortestPath = g.ShortestPath(0, 3);

        Console.Write("Shortest path from 0 to 3: ");
        foreach (int vertex in shortestPath)
        {
            Console.Write(vertex + " ");
        }
    }
}
