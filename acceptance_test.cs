
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

    public List<int> ShortestPath(int start, int end)
    {
        Queue<List<int>> queue = new Queue<List<int>>();
        List<int> path = new List<int>();
        path.Add(start);
        queue.Enqueue(path);

        while (queue.Count > 0)
        {
            path = queue.Dequeue();
            int lastNode = path[path.Count - 1];

            if (lastNode == end)
            {
                return path;
            }

            foreach (var neighbor in adj[lastNode])
            {
                if (!path.Contains(neighbor))
                {
                    List<int> newPath = new List<int>(path);
                    newPath.Add(neighbor);
                    queue.Enqueue(newPath);
                }
            }
        }

        return null;
    }
}

class Program
{
    static void Main()
    {
        Graph g = new Graph(4);
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 2);
        g.AddEdge(2, 0);
        g.AddEdge(2, 3);
        g.AddEdge(3, 3);

        List<int> shortestPath = g.ShortestPath(0, 3);

        if (shortestPath != null)
        {
            Console.Write("Shortest Path: ");
            foreach (var node in shortestPath)
            {
                Console.Write(node + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("Path does not exist.");
        }
    }
}
