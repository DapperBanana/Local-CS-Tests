
using System;
using System.Collections.Generic;

class Node
{
    public char Symbol { get; set; }
    public int Frequency { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
}

class Huffman
{
    private static Dictionary<char, string> _codes = new Dictionary<char, string>();
    
    public static void Compress(string text)
    {
        Dictionary<char, int> frequencies = new Dictionary<char, int>();
        
        foreach (char c in text)
        {
            if (frequencies.ContainsKey(c))
            {
                frequencies[c]++;
            }
            else
            {
                frequencies[c] = 1;
            }
        }
        
        List<Node> nodes = new List<Node>();
        foreach (var keyValuePair in frequencies)
        {
            nodes.Add(new Node { Symbol = keyValuePair.Key, Frequency = keyValuePair.Value });
        }
        
        while (nodes.Count > 1)
        {
            nodes.Sort((a, b) => a.Frequency.CompareTo(b.Frequency));
            Node left = nodes[0];
            Node right = nodes[1];
            nodes.Remove(left);
            nodes.Remove(right);
            Node parent = new Node
            {
                Symbol = '\0',
                Frequency = left.Frequency + right.Frequency,
                Left = left,
                Right = right
            };
            nodes.Add(parent);
        }
        
        Traverse(nodes[0], "");
        
        foreach (char c in text)
        {
            Console.Write(_codes[c]);
        }
        
        Console.WriteLine();
    }
    
    private static void Traverse(Node node, string code)
    {
        if (node.Left == null && node.Right == null)
        {
            _codes[node.Symbol] = code;
        }
        else
        {
            Traverse(node.Left, code + "0");
            Traverse(node.Right, code + "1");
        }
    }
}

class Program
{
    static void Main()
    {
        string text = "hello world";
        Huffman.Compress(text);
    }
}
