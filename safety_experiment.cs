
using System;
using System.Collections.Generic;
using System.Linq;

class HuffmanNode
{
    public char Character { get; set; }
    public int Frequency { get; set; }
    public HuffmanNode Left { get; set; }
    public HuffmanNode Right { get; set; }
}

class Huffman
{
    public static string Encode(string input)
    {
        Dictionary<char, int> frequencies = input.GroupBy(c => c)
                                                  .ToDictionary(g => g.Key, g => g.Count());

        List<HuffmanNode> nodes = frequencies.Select(kv => new HuffmanNode { Character = kv.Key, Frequency = kv.Value })
                                             .ToList();

        while (nodes.Count > 1)
        {
            List<HuffmanNode> sortedNodes = nodes.OrderBy(n => n.Frequency).ToList();

            if (sortedNodes.Count >= 2)
            {
                HuffmanNode parent = new HuffmanNode
                {
                    Character = ' ',
                    Frequency = sortedNodes[0].Frequency + sortedNodes[1].Frequency,
                    Left = sortedNodes[0],
                    Right = sortedNodes[1]
                };

                nodes.Remove(sortedNodes[0]);
                nodes.Remove(sortedNodes[1]);
                nodes.Add(parent);
            }
        }

        Dictionary<char, string> codes = new Dictionary<char, string>();
        Traverse(nodes.First(), "", codes);

        string encoded = string.Join("", input.Select(c => codes[c]));

        return encoded;
    }

    private static void Traverse(HuffmanNode node, string code, Dictionary<char, string> codes)
    {
        if (node == null)
        {
            return;
        }

        if (node.Left != null)
        {
            Traverse(node.Left, code + "0", codes);
        }

        if (node.Right != null)
        {
            Traverse(node.Right, code + "1", codes);
        }

        if (node.Character != ' ')
        {
            codes[node.Character] = code;
        }
    }
}

class Program
{
    static void Main()
    {
        string input = "huffman coding is a data compression algorithm";

        string encoded = Huffman.Encode(input);

        Console.WriteLine("Encoded: " + encoded);
    }
}
