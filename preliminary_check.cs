using System;
using System.Collections.Generic;
using System.Text;

public class HuffmanNode : IComparable<HuffmanNode>
{
    public char? Symbol { get; set; }
    public int Frequency { get; set; }
    public HuffmanNode Left { get; set; }
    public HuffmanNode Right { get; set; }

    public int CompareTo(HuffmanNode other)
    {
        return Frequency - other.Frequency;
    }
}

public class HuffmanCoding
{
    private Dictionary<char, string> _codes = new Dictionary<char, string>();
    private Dictionary<string, char> _reverseCodes = new Dictionary<string, char>();

    public string Encode(string input)
    {
        var frequency = BuildFrequencyTable(input);
        var root = BuildHuffmanTree(frequency);
        GenerateCodes(root, "");

        StringBuilder encoded = new StringBuilder();
        foreach (char c in input)
        {
            encoded.Append(_codes[c]);
        }
        return encoded.ToString();
    }

    public string Decode(string encoded)
    {
        StringBuilder decoded = new StringBuilder();
        HuffmanNode current = null;
        current = _root;

        foreach (char bit in encoded)
        {
            if (bit == '0')
                current = current.Left;
            else
                current = current.Right;

            if (current.Symbol.HasValue)
            {
                decoded.Append(current.Symbol.Value);
                current = _root;
            }
        }
        return decoded.ToString();
    }

    private HuffmanNode _root;

    private Dictionary<char, int> BuildFrequencyTable(string input)
    {
        var freq = new Dictionary<char, int>();
        foreach (char c in input)
        {
            if (!freq.ContainsKey(c))
                freq[c] = 0;
            freq[c]++;
        }
        return freq;
    }

    private HuffmanNode BuildHuffmanTree(Dictionary<char, int> frequency)
    {
        var priorityQueue = new List<HuffmanNode>();

        foreach (var kvp in frequency)
        {
            priorityQueue.Add(new HuffmanNode { Symbol = kvp.Key, Frequency = kvp.Value });
        }
        priorityQueue.Sort();

        while (priorityQueue.Count > 1)
        {
            var left = priorityQueue[0];
            var right = priorityQueue[1];

            var merged = new HuffmanNode
            {
                Symbol = null,
                Frequency = left.Frequency + right.Frequency,
                Left = left,
                Right = right
            };

            priorityQueue.RemoveAt(0);
            priorityQueue.RemoveAt(0);
            priorityQueue.Add(merged);
            priorityQueue.Sort();
        }

        _root = priorityQueue[0];
        return _root;
    }

    private void GenerateCodes(HuffmanNode node, string code)
    {
        if (node == null)
            return;

        if (node.Symbol.HasValue)
        {
            _codes[node.Symbol.Value] = code;
            _reverseCodes[code] = node.Symbol.Value;
        }

        GenerateCodes(node.Left, code + "0");
        GenerateCodes(node.Right, code + "1");
    }
}

class Program
{
    static void Main()
    {
        string input = "this is an example for huffman encoding";

        HuffmanCoding huffman = new HuffmanCoding();

        string encoded = huffman.Encode(input);
        Console.WriteLine("Encoded: " + encoded);

        string decoded = huffman.Decode(encoded);
        Console.WriteLine("Decoded: " + decoded);
    }
}