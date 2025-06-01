
using System;
using System.Collections.Generic;

class Node
{
    public char ch;
    public int freq;
    public Node left, right;
}

class Huffman
{
    public static void Main()
    {
        string text = "hello world";
        Console.WriteLine("Original text: " + text);

        Dictionary<char, int> freqMap = new Dictionary<char, int>();
        foreach (char c in text)
        {
            if (freqMap.ContainsKey(c))
            {
                freqMap[c]++;
            }
            else
            {
                freqMap[c] = 1;
            }
        }

        List<Node> nodes = new List<Node>();
        foreach (var entry in freqMap)
        {
            nodes.Add(new Node { ch = entry.Key, freq = entry.Value });
        }

        while (nodes.Count > 1)
        {
            nodes.Sort((x, y) => x.freq - y.freq);
            Node left = nodes[0];
            Node right = nodes[1];

            nodes.Remove(left);
            nodes.Remove(right);

            Node parent = new Node { ch = '$', freq = left.freq + right.freq, left = left, right = right };
            nodes.Add(parent);
        }

        Node root = nodes[0];
        string[] codes = new string[128];
        GenerateCodes(root, codes, "");

        string compressed = "";
        foreach (char c in text)
        {
            compressed += codes[c];
        }

        Console.WriteLine("Compressed text: " + compressed);
    }

    private static void GenerateCodes(Node node, string[] codes, string code)
    {
        if (node == null)
            return;

        if (node.ch != '$')
        {
            codes[node.ch] = code;
        }

        GenerateCodes(node.left, codes, code + "0");
        GenerateCodes(node.right, codes, code + "1");
    }
}
