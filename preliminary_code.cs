using System;
using System.Collections.Generic;
using System.Linq;

class HuffmanNode : IComparable<HuffmanNode>
{
    public char? Symbol { get; set; }
    public int Frequency { get; set; }
    public HuffmanNode Left { get; set; }
    public HuffmanNode Right { get; set; }

    public int CompareTo(HuffmanNode other)
    {
        return this.Frequency - other.Frequency;
    }
}

class HuffmanCoding
{
    private Dictionary<char, string> _codes = new Dictionary<char, string>();
    private HuffmanNode _root;

    public string Compress(string input)
    {
        // Count frequency of each character
        var frequency = new Dictionary<char, int>();
        foreach (var ch in input)
        {
            if (!frequency.ContainsKey(ch))
                frequency[ch] = 0;
            frequency[ch]++;
        }

        // Build priority queue
        var priorityQueue = new SortedSet<HuffmanNode>(Comparer<HuffmanNode>.Create((a, b) =>
        {
            int compare = a.Frequency - b.Frequency;
            if (compare == 0 && a.Symbol != null && b.Symbol != null)
                compare = a.Symbol.Value - b.Symbol.Value;
            return compare;
        }));

        foreach (var kvp in frequency)
        {
            priorityQueue.Add(new HuffmanNode { Symbol = kvp.Key, Frequency = kvp.Value });
        }

        // Build Huffman Tree
        while (priorityQueue.Count > 1)
        {
            var left = priorityQueue.Min;
            priorityQueue.Remove(left);
            var right = priorityQueue.Min;
            priorityQueue.Remove(right);

            var parent = new HuffmanNode
            {
                Symbol = null,
                Frequency = left.Frequency + right.Frequency,
                Left = left,
                Right = right
            };
            priorityQueue.Add(parent);
        }

        _root = priorityQueue.Min;

        // Generate codes
        GenerateCodes(_root, "");

        // Encode input
        var encoded = "";
        foreach (var ch in input)
        {
            encoded += _codes[ch];
        }

        return encoded;
    }

    private void GenerateCodes(HuffmanNode node, string code)
    {
        if (node == null)
            return;
        if (node.Symbol != null)
        {
            _codes[node.Symbol.Value] = code;
            return;
        }
        GenerateCodes(node.Left, code + "0");
        GenerateCodes(node.Right, code + "1");
    }

    public string Decompress(string encoded, Dictionary<char, string> codes)
    {
        // Rebuild reverse mapping
        var reverseCodes = codes.ToDictionary(kvp => kvp.Value, kvp => kvp.Key);
        var currentCode = "";
        var decoded = "";

        foreach (var bit in encoded)
        {
            currentCode += bit;
            if (reverseCodes.ContainsKey(currentCode))
            {
                decoded += reverseCodes[currentCode];
                currentCode = "";
            }
        }
        return decoded;
    }

    public Dictionary<char, string> GetCodes()
    {
        return _codes;
    }
}

class Program
{
    static void Main()
    {
        var input = "this is an example of huffman encoding";

        var huffman = new HuffmanCoding();
        var compressedBits = huffman.Compress(input);
        var codes = huffman.GetCodes();

        Console.WriteLine("Original text:");
        Console.WriteLine(input);
        Console.WriteLine("\nCompressed bit string:");
        Console.WriteLine(compressedBits);
        Console.WriteLine("\nHuffman codes:");
        foreach (var kvp in codes)
        {
            Console.WriteLine($"'{kvp.Key}': {kvp.Value}");
        }

        var decompressed = huffman.Decompress(compressedBits, codes);
        Console.WriteLine("\nDecompressed text:");
        Console.WriteLine(decompressed);
    }
}