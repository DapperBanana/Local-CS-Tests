
using System;
using System.Collections.Generic;

public class HuffmanNode
{
    public char character;
    public int frequency;
    public HuffmanNode leftChild;
    public HuffmanNode rightChild;
}

public class HuffmanTree
{
    private List<HuffmanNode> nodes = new List<HuffmanNode>();
    public HuffmanNode root;

    public void BuildTree(Dictionary<char, int> frequencies)
    {
        foreach (var kvp in frequencies)
        {
            nodes.Add(new HuffmanNode { character = kvp.Key, frequency = kvp.Value });
        }

        while (nodes.Count > 1)
        {
            List<HuffmanNode> orderedNodes = nodes.OrderBy(node => node.frequency).ToList();
            
            if (orderedNodes.Count >= 2)
            {
                List<HuffmanNode> takenNodes = orderedNodes.Take(2).ToList();

                HuffmanNode parent = new HuffmanNode
                {
                    character = '*',
                    frequency = takenNodes[0].frequency + takenNodes[1].frequency,
                    leftChild = takenNodes[0],
                    rightChild = takenNodes[1]
                };

                nodes.Remove(takenNodes[0]);
                nodes.Remove(takenNodes[1]);
                nodes.Add(parent);
            }

            root = nodes.FirstOrDefault();
        }
    }

    public Dictionary<char, string> GenerateCodes()
    {
        Dictionary<char, string> codes = new Dictionary<char, string>();
        if (root != null)
        {
            GenerateCodes(root, "", codes);
        }
        return codes;
    }

    private void GenerateCodes(HuffmanNode node, string code, Dictionary<char, string> codes)
    {
        if (node != null)
        {
            if (node.character != '*')
            {
                codes.Add(node.character, code);
            }

            GenerateCodes(node.leftChild, code + "0", codes);
            GenerateCodes(node.rightChild, code + "1", codes);
        }
    }

    public string Compress(string text, Dictionary<char, string> codes)
    {
        string compressedText = "";
        foreach (var character in text)
        {
            compressedText += codes[character];
        }
        return compressedText;
    }

    public string Decompress(string compressedText, Dictionary<char, string> codes)
    {
        string decompressedText = "";
        string currentCode = "";
        foreach (var bit in compressedText)
        {
            currentCode += bit;
            if (codes.ContainsValue(currentCode))
            {
                decompressedText += codes.FirstOrDefault(x => x.Value == currentCode).Key;
                currentCode = "";
            }
        }
        return decompressedText;
    }
}

class Program
{
    static void Main()
    {
        string text = "hello world";

        Dictionary<char, int> frequencies = new Dictionary<char, int>();
        foreach (var c in text)
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

        HuffmanTree tree = new HuffmanTree();
        tree.BuildTree(frequencies);

        Dictionary<char, string> codes = tree.GenerateCodes();

        string compressedText = tree.Compress(text, codes);
        Console.WriteLine("Compressed Text: " + compressedText);

        string decompressedText = tree.Decompress(compressedText, codes);
        Console.WriteLine("Decompressed Text: " + decompressedText);
    }
}
