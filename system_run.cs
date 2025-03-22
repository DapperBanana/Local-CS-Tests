
using System;
using System.Collections.Generic;
using System.Linq;

class Node
{
    public char Symbol { get; set; }
    public int Frequency { get; set; }
    public Node Left { get; set; }
    public Node Right { get; set; }
}

class Huffman
{
    public static Dictionary<char, int> CountFrequencies(string text)
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
        return frequencies;
    }

    public static Node BuildHuffmanTree(Dictionary<char, int> frequencies)
    {
        List<Node> nodes = frequencies.Select(kv => new Node { Symbol = kv.Key, Frequency = kv.Value }).ToList();

        while (nodes.Count > 1)
        {
            List<Node> sortedNodes = nodes.OrderBy(n => n.Frequency).ToList();

            if (sortedNodes.Count >= 2)
            {
                Node mergeNode = new Node
                {
                    Symbol = '|',
                    Frequency = sortedNodes[0].Frequency + sortedNodes[1].Frequency,
                    Left = sortedNodes[0],
                    Right = sortedNodes[1]
                };
                nodes.Remove(sortedNodes[0]);
                nodes.Remove(sortedNodes[1]);
                nodes.Add(mergeNode);
            }
        }

        return nodes.FirstOrDefault();
    }

    public static Dictionary<char, string> BuildHuffmanCodes(Node root)
    {
        var huffmanCodes = new Dictionary<char, string>();
        BuildHuffmanCodesRecursive(root, "", huffmanCodes);
        return huffmanCodes;
    }

    private static void BuildHuffmanCodesRecursive(Node node, string code, Dictionary<char, string> huffmanCodes)
    {
        if (node == null)
        {
            return;
        }

        if (node.Symbol != '|')
        {
            huffmanCodes.Add(node.Symbol, code);
        }

        BuildHuffmanCodesRecursive(node.Left, code + "0", huffmanCodes);
        BuildHuffmanCodesRecursive(node.Right, code + "1", huffmanCodes);
    }

    public static string Compress(string text)
    {
        Dictionary<char, int> frequencies = CountFrequencies(text);
        Node root = BuildHuffmanTree(frequencies);
        Dictionary<char, string> huffmanCodes = BuildHuffmanCodes(root);

        string compressedText = "";
        foreach (char c in text)
        {
            compressedText += huffmanCodes[c];
        }

        return compressedText;
    }

    public static void Main(string[] args)
    {
        string text = "hello world";
        string compressedText = Compress(text);

        Console.WriteLine($"Original Text: {text}");
        Console.WriteLine($"Compressed Text: {compressedText}");
    }
}
