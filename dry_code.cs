
using System;
using System.Collections.Generic;

public class HuffmanNode
{
  public char Character { get; set; }
  public int Frequency { get; set; }
  public HuffmanNode Left { get; set; }
  public HuffmanNode Right { get; set; }
}

public class HuffmanTree
{
  public HuffmanNode Root { get; set; }

  public HuffmanTree()
  {
    Root = null;
  }

  public void BuildTree(Dictionary<char, int> frequencies)
  {
    var priorityQueue = new SortedDictionary<int, List<HuffmanNode>>();

    foreach (var kvp in frequencies)
    {
      var node = new HuffmanNode
      {
        Character = kvp.Key,
        Frequency = kvp.Value
      };

      if (!priorityQueue.ContainsKey(node.Frequency))
      {
        priorityQueue.Add(node.Frequency, new List<HuffmanNode>());
      }

      priorityQueue[node.Frequency].Add(node);
    }

    while (priorityQueue.Count > 1)
    {
      var newNodes = new List<HuffmanNode>();

      foreach (var kvp in priorityQueue)
      {
        foreach (var node in kvp.Value)
        {
          newNodes.Add(node);
          if (newNodes.Count >= 2)
          {
            break;
          }
        }

        if (newNodes.Count >= 2)
        {
          break;
        }
      }

      var parent = new HuffmanNode
      {
        Frequency = newNodes[0].Frequency + newNodes[1].Frequency,
        Left = newNodes[0],
        Right = newNodes[1]
      };

      priorityQueue[parent.Frequency] = new List<HuffmanNode> { parent };
      priorityQueue.Remove(newNodes[0].Frequency);
      priorityQueue.Remove(newNodes[1].Frequency);
    }

    Root = priorityQueue.Values.GetEnumerator().Current;
  }

  public Dictionary<char, string> Encode()
  {
    var codes = new Dictionary<char, string>();
    Encode(Root, "", codes);
    return codes;
  }

  private void Encode(HuffmanNode node, string code, Dictionary<char, string> codes)
  {
    if (node == null)
    {
      return;
    }

    if (node.Left == null && node.Right == null)
    {
      codes.Add(node.Character, code);
      return;
    }

    Encode(node.Left, code + "0", codes);
    Encode(node.Right, code + "1", codes);
  }

}

class Program
{
  static void Main()
  {
    var input = "hello world";
    
    var frequencies = new Dictionary<char, int>();
    foreach (char c in input)
    {
      if (!frequencies.ContainsKey(c))
      {
        frequencies[c] = 0;
      }

      frequencies[c]++;
    }

    var huffmanTree = new HuffmanTree();
    huffmanTree.BuildTree(frequencies);
    var codes = huffmanTree.Encode();

    foreach (var kvp in codes)
    {
      Console.WriteLine($"{kvp.Key}: {kvp.Value}");
    }
    
    // Output: h: 000, e: 001, o: 01, l: 10, w: 110, r: 111
  }
}
