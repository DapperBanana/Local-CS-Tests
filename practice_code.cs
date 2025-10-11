
using System;
using System.Collections.Generic;

class Graph
{
    private int vertices;
    private List<Tuple<int, int>>[] adjList;

    public Graph(int vertices)
    {
        this.vertices = vertices;
        adjList = new List<Tuple<int, int>>[vertices];
        for (int i = 0; i < vertices; i++)
        {
            adjList[i] = new List<Tuple<int, int>>();
        }
    }

    public void AddEdge(int source, int dest, int weight)
    {
        adjList[source].Add(new Tuple<int, int>(dest, weight));
        adjList[dest].Add(new Tuple<int, int>(source, weight));
    }

    public void Dijkstra(int source)
    {
        int[] distance = new int[vertices];
        bool[] visited = new bool[vertices];
        for (int i = 0; i < vertices; i++)
        {
            distance[i] = int.MaxValue;
            visited[i] = false;
        }

        distance[source] = 0;

        for (int i = 0; i < vertices - 1; i++)
        {
            int u = MinDistance(distance, visited);
            visited[u] = true;

            foreach (var tuple in adjList[u])
            {
                int v = tuple.Item1;
                int weight = tuple.Item2;

                if (!visited[v] && distance[u] != int.MaxValue && distance[u] + weight < distance[v])
                {
                    distance[v] = distance[u] + weight;
                }
            }
        }

        PrintSolution(distance);
    }

    private int MinDistance(int[] distance, bool[] visited)
    {
        int min = int.MaxValue, minIndex = -1;

        for (int i = 0; i < vertices; i++)
        {
            if (!visited[i] && distance[i] <= min)
            {
                min = distance[i];
                minIndex = i;
            }
        }

        return minIndex;
    }

    private void PrintSolution(int[] distance)
    {
        Console.WriteLine("Vertex \t Distance from Source");
        for (int i = 0; i < vertices; i++)
        {
            Console.WriteLine(i + " \t " + distance[i]);
        }
    }
}

class Program
{
    public static void Main()
    {
        Graph graph = new Graph(5);
        graph.AddEdge(0, 1, 6);
        graph.AddEdge(0, 3, 1);
        graph.AddEdge(1, 3, 2);
        graph.AddEdge(1, 4, 2);
        graph.AddEdge(1, 2, 5);
        graph.AddEdge(2, 4, 5);
        graph.AddEdge(3, 4, 1);

        graph.Dijkstra(0);
    }
}
