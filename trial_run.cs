
using System;
using System.Collections.Generic;
using System.Linq;

namespace HuffmanCompression
{
    class Node
    {
        public char Symbol { get; set; }
        public int Frequency { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }
    }

    class Huffman
    {
        public static Dictionary<char, string> Encode(string text)
        {
            var freqTable = new Dictionary<char, int>();
            foreach (var c in text)
            {
                if (freqTable.ContainsKey(c))
                    freqTable[c]++;
                else
                    freqTable[c] = 1;
            }

            var nodes = freqTable.Select(kv => new Node { Symbol = kv.Key, Frequency = kv.Value }).ToList();

            while (nodes.Count > 1)
            {
                nodes.Sort((a, b) => a.Frequency - b.Frequency);
                var node = new Node
                {
                    Symbol = '\0',
                    Frequency = nodes[0].Frequency + nodes[1].Frequency,
                    Left = nodes[0],
                    Right = nodes[1]
                };
                nodes.RemoveRange(0, 2);
                nodes.Add(node);
            }

            var root = nodes.Single();

            var codes = new Dictionary<char, string>();
            EncodeRecursive(root, "", codes);

            return codes;
        }

        private static void EncodeRecursive(Node node, string code, Dictionary<char, string> codes)
        {
            if (node.Symbol != '\0')
            {
                codes[node.Symbol] = code;
                return;
            }

            EncodeRecursive(node.Left, code + "0", codes);
            EncodeRecursive(node.Right, code + "1", codes);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = "hello world";

            var codes = Huffman.Encode(text);

            foreach (var kv in codes)
            {
                Console.WriteLine($"'{kv.Key}': {kv.Value}");
            }

            string compressedText = string.Join("", text.Select(c => codes[c]));

            Console.WriteLine("Compressed text: " + compressedText);
        }
    }
}
