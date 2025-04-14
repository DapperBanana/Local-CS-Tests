
using System;
using System.Collections.Generic;

public class Graph
{
    private int V;
    private List<List<int>> adj;

    public Graph(int V)
    {
        this.V = V;
        adj = new List<List<int>>();

        for (int i = 0; i < V; i++)
        {
            adj.Add(new List<int>());
        }
    }

    public void AddEdge(int u, int v)
    {
        adj[u].Add(v);
        adj[v].Add(u);
    }

    private bool IsCyclicUtil(int v, bool[] visited, int parent)
    {
        visited[v] = true;

        foreach (var i in adj[v])
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
            if (!visited[i])
            {
                if (IsCyclicUtil(i, visited, -1))
                {
                    return true;
                }
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
}

class Program
{
    static void Main(string[] args)
    {
        Graph graph = new Graph(5);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(0, 3);
        graph.AddEdge(1, 4);

        if (graph.IsTree())
        {
            Console.WriteLine("The graph is a tree");
        }
        else
        {
            Console.WriteLine("The graph is not a tree");
        }
    }
}
