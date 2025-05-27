
using System;
using System.Collections.Generic;

class MarkovChain
{
    private Dictionary<string, List<string>> chain = new Dictionary<string, List<string>>();
    private Random random = new Random();

    public void Train(string[] input)
    {
        for (int i = 0; i < input.Length - 1; i++)
        {
            if (!chain.ContainsKey(input[i]))
            {
                chain.Add(input[i], new List<string>());
            }

            chain[input[i]].Add(input[i + 1]);
        }
    }

    public string Generate(int length)
    {
        string current = chain.Keys.ElementAt(random.Next(chain.Count));
        string sentence = current;

        for (int i = 0; i < length - 1; i++)
        {
            if (!chain.ContainsKey(current))
            {
                break;
            }

            string next = chain[current][random.Next(chain[current].Count)];
            sentence += " " + next;
            current = next;
        }

        return sentence;
    }
}

class Program
{
    static void Main()
    {
        string[] input = { "The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog" };
        MarkovChain markovChain = new MarkovChain();
        markovChain.Train(input);

        string randomSentence = markovChain.Generate(10);
        Console.WriteLine(randomSentence);
    }
}
