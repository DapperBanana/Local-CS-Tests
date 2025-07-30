
using System;
using System.Collections.Generic;

class Graph
{
    private int V;
    private List<List<int>> adj;

    public Graph(int v)
    {
        V = v;
        adj = new List<List<int>>(V);
        
        for (int i = 0; i < V; i++)
        {
            adj.Add(new List<int>());
        }
    }

    private bool IsCyclicUtil(int v, bool[] visited, int parent)
    {
        visited[v] = true;

        foreach (int i in adj[v])
        {
            if (!visited[i])
            {
                if (IsCyclicUtil(i, visited, v))
                {
                    return true;
                }
            }
            else if (i != parent)
            {
                return true;
            }
        }

        return false;
    }

    private bool IsCyclic()
    {
        bool[] visited = new bool[V];

        for (int i = 0; i < V; i++)
        {
            visited[i] = false;
        }

        for (int i = 0; i < V; i++)
        {
            if (!visited[i] && IsCyclicUtil(i, visited, -1))
            {
                return true;
            }
        }

        return false;
    }

    public bool IsTree()
    {
        if (IsCyclic())
        {
            return false;
        }

        for (int i = 0; i < V; i++)
        {
            if (adj[i].Count > 1)
            {
                return false;
            }
        }

        return true;
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
        adj[w].Add(v);
    }
}

class Program
{
    public static void Main()
    {
        Graph graph = new Graph(5);

        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(0, 3);
        graph.AddEdge(1, 4);

        if (graph.IsTree())
        {
            Console.WriteLine("Given graph is a tree");
        }
        else
        {
            Console.WriteLine("Given graph is not a tree");
        }
    }
}
