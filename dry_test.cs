using System;
using System.Collections.Generic;

public class Graph
{
    private int vertices;
    private List<int>[] adjacencyList;

    public Graph(int vertices)
    {
        this.vertices = vertices;
        adjacencyList = new List<int>[vertices];
        for (int i = 0; i < vertices; i++)
        {
            adjacencyList[i] = new List<int>();
        }
    }

    public void AddEdge(int u, int v)
    {
        adjacencyList[u].Add(v);
        adjacencyList[v].Add(u);
    }

    public bool IsTree()
    {
        bool[] visited = new bool[vertices];
        // Start DFS traversal from vertex 0
        if (HasCycle(0, -1, visited))
            return false;

        // Check if all vertices are visited (connected)
        for (int i = 0; i < vertices; i++)
        {
            if (!visited[i])
                return false;
        }

        return true;
    }

    private bool HasCycle(int current, int parent, bool[] visited)
    {
        visited[current] = true;

        foreach (int neighbor in adjacencyList[current])
        {
            if (!visited[neighbor])
            {
                if (HasCycle(neighbor, current, visited))
                    return true;
            }
            else if (neighbor != parent)
            {
                // Found a cycle
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
        // Example: create a graph with 5 vertices
        Graph graph = new Graph(5);
        graph.AddEdge(0, 1);
        graph.AddEdge(0, 2);
        graph.AddEdge(1, 3);
        graph.AddEdge(1, 4);

        Console.WriteLine("Is the graph a tree? " + (graph.IsTree() ? "Yes" : "No"));
    }
}