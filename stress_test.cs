
using System;
using System.Collections.Generic;

public class Graph
{
    private int V;
    private List<List<int>> adjList;

    public Graph(int v)
    {
        V = v;
        adjList = new List<List<int>>();
        for (int i = 0; i < V; i++)
        {
            adjList.Add(new List<int>());
        }
    }

    public void addEdge(int u, int v)
    {
        adjList[u].Add(v);
        adjList[v].Add(u);
    }

    public bool isTree()
    {
        bool[] visited = new bool[V];
        if (isCyclic(0, visited, -1))
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

    private bool isCyclic(int v, bool[] visited, int parent)
    {
        visited[v] = true;

        foreach (int i in adjList[v])
        {
            if (!visited[i])
            {
                if (isCyclic(i, visited, v))
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
}

class Program
{
    static void Main()
    {
        Graph g = new Graph(5);
        g.addEdge(0, 1);
        g.addEdge(0, 2);
        g.addEdge(1, 3);
        g.addEdge(3, 4);

        if (g.isTree())
        {
            Console.WriteLine("The graph is a tree.");
        }
        else
        {
            Console.WriteLine("The graph is not a tree.");
        }
    }
}
