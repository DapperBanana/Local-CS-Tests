
using System;
using System.Collections.Generic;
using System.Linq;

namespace HuffmanCoding
{
    public class Node
    {
        public char Symbol { get; set; }
        public int Frequency { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
    }

    public class Huffman
    {
        public static Dictionary<char, string> Encode(string text)
        {
            Dictionary<char, int> frequencyMap = text.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
            List<Node> nodes = frequencyMap.Select(pair => new Node { Symbol = pair.Key, Frequency = pair.Value }).ToList();

            while (nodes.Count > 1)
            {
                nodes = nodes.OrderBy(n => n.Frequency).ToList();

                Node left = nodes[0];
                Node right = nodes[1];
                nodes = nodes.Skip(2).ToList();

                Node newNode = new Node
                {
                    Symbol = '\0',
                    Frequency = left.Frequency + right.Frequency,
                    LeftChild = left,
                    RightChild = right
                };

                nodes.Add(newNode);
            }

            Dictionary<char, string> encodingMap = new Dictionary<char, string>();
            GenerateCodes(nodes[0], "", encodingMap);

            return encodingMap;
        }

        private static void GenerateCodes(Node node, string code, Dictionary<char, string> encodingMap)
        {
            if (node == null)
            {
                return;
            }

            if (node.Symbol != '\0')
            {
                encodingMap.Add(node.Symbol, code);
            }

            GenerateCodes(node.LeftChild, code + "0", encodingMap);
            GenerateCodes(node.RightChild, code + "1", encodingMap);
        }

        public static string Compress(string text, Dictionary<char, string> encodingMap)
        {
            string compressedText = string.Join("", text.Select(c => encodingMap[c]));
            return compressedText;
        }

        public static string Decompress(string compressedText, Dictionary<char, string> encodingMap)
        {
            Dictionary<string, char> decodingMap = encodingMap.ToDictionary(kv => kv.Value, kv => kv.Key);

            string decodedText = "";
            string code = "";

            foreach (char bit in compressedText)
            {
                code += bit;
                if (decodingMap.ContainsKey(code))
                {
                    decodedText += decodingMap[code];
                    code = "";
                }
            }

            return decodedText;
        }

        static void Main(string[] args)
        {
            string text = "hello world";
            Console.WriteLine("Original text: " + text);

            Dictionary<char, string> encodingMap = Encode(text);
            string compressedText = Compress(text, encodingMap);
            Console.WriteLine("Compressed text: " + compressedText);

            string decompressedText = Decompress(compressedText, encodingMap);
            Console.WriteLine("Decompressed text: " + decompressedText);
        }
    }
}
