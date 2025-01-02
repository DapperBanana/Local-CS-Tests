
using System;
using System.Collections.Generic;
using System.Linq;

class HuffmanNode
{
    public char Symbol;
    public int Frequency;
    public HuffmanNode Left;
    public HuffmanNode Right;
}

class HuffmanTree
{
    private SortedDictionary<char, int> frequencyTable;
    private Dictionary<char, string> encodingTable;
    private HuffmanNode root;

    public HuffmanTree(string text)
    {
        frequencyTable = new SortedDictionary<char, int>();
        foreach (char c in text)
        {
            if (frequencyTable.ContainsKey(c))
                frequencyTable[c]++;
            else
                frequencyTable[c] = 1;
        }

        List<HuffmanNode> nodes = frequencyTable.Select(pair => new HuffmanNode { Symbol = pair.Key, Frequency = pair.Value }).ToList();
        while (nodes.Count > 1)
        {
            List<HuffmanNode> orderedNodes = nodes.OrderBy(node => node.Frequency).ToList<HuffmanNode>();

            if (orderedNodes.Count >= 2)
            {
                List<HuffmanNode> taken = orderedNodes.Take(2).ToList<HuffmanNode>();

                HuffmanNode parent = new HuffmanNode
                {
                    Symbol = '\0',
                    Frequency = taken[0].Frequency + taken[1].Frequency,
                    Left = taken[0],
                    Right = taken[1]
                };

                nodes.Remove(taken[0]);
                nodes.Remove(taken[1]);
                nodes.Add(parent);
            }

            root = nodes.FirstOrDefault();
        }

        encodingTable = new Dictionary<char, string>();
        Encode(root, "");
    }

    private void Encode(HuffmanNode node, string encoding)
    {
        if (node == null)
            return;

        if (node.Left == null && node.Right == null)
            encodingTable[node.Symbol] = encoding;

        Encode(node.Left, encoding + "0");
        Encode(node.Right, encoding + "1");
    }

    public string Compress(string text)
    {
        string compressedText = "";
        foreach (char c in text)
        {
            compressedText += encodingTable[c];
        }
        return compressedText;
    }

    public string Decompress(string compressedText)
    {
        string decompressedText = "";
        HuffmanNode currentNode = root;
        foreach (char bit in compressedText)
        {
            if (bit == '0')
                currentNode = currentNode.Left;
            else if (bit == '1')
                currentNode = currentNode.Right;

            if (currentNode.Left == null && currentNode.Right == null)
            {
                decompressedText += currentNode.Symbol;
                currentNode = root;
            }
        }
        return decompressedText;
    }
}

class Program
{
    static void Main()
    {
        string text = "Hello, World!";
        HuffmanTree huffmanTree = new HuffmanTree(text);
        string compressedText = huffmanTree.Compress(text);
        string decompressedText = huffmanTree.Decompress(compressedText);

        Console.WriteLine("Original text: " + text);
        Console.WriteLine("Compressed text: " + compressedText);
        Console.WriteLine("Decompressed text: " + decompressedText);
    }
}
