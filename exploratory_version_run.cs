
using System;
using System.Collections.Generic;

class Graph
{
    private int V; // Number of vertices
    private List<int>[] adj; // Adjacency list

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

        foreach (int neighbor in adj[v])
        {
            if (!visited[neighbor])
            {
                if (IsCyclicUtil(neighbor, visited, v))
                {
                    return true;
                }
            }
            else if (neighbor != parent)
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

class MainClass
{
    public static void Main(string[] args)
    {
        Graph g = new Graph(5);
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 3);
        g.AddEdge(3, 4);

        if (g.IsTree())
        {
            Console.WriteLine("The given graph is a tree.");
        }
        else
        {
            Console.WriteLine("The given graph is not a tree.");
        }
    }
}
