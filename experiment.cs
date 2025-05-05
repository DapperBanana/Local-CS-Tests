
using System;
using System.Collections.Generic;

class Graph
{
    private int V; // No. of vertices
    private List<int>[] adj; // Adjacency List

    public Graph(int V)
    {
        this.V = V;
        adj = new List<int>[V];
        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
        adj[w].Add(v);
    }

    private bool IsCyclicUtil(int v, bool[] visited, int parent)
    {
        visited[v] = true;

        foreach (int i in adj[v])
        {
            if (!visited[i])
            {
                if (IsCyclicUtil(i, visited, v))
                    return true;
            }
            else if (i != parent)
            {
                return true;
            }
        }
        return false;
    }

    public bool IsTree()
    {
        bool[] visited = new bool[V];
        if (IsCyclicUtil(0, visited, -1))
        {
            return false;
        }

        for (int i = 0; i < V; i++)
        {
            if (!visited[i])
            {
                return false;
            }
        }

        return true;
    }
}

class Program
{
    public static void Main()
    {
        Graph g = new Graph(5);
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(2, 3);
        g.AddEdge(3, 4);

        if (g.IsTree())
        {
            Console.WriteLine("The graph is a tree.");
        }
        else
        {
            Console.WriteLine("The graph is not a tree.");
        }
    }
}
