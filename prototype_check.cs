
using System;
using System.Collections.Generic;

class MarkovChain
{
    private Dictionary<string, List<string>> chains = new Dictionary<string, List<string>>();
    private Random rand = new Random();

    public void AddToken(string token1, string token2)
    {
        if (!chains.ContainsKey(token1))
        {
            chains[token1] = new List<string>();
        }

        chains[token1].Add(token2);
    }

    public string GenerateSentence(int length)
    {
        List<string> sentence = new List<string>();
        string currentToken = chains.Keys.ElementAt(rand.Next(chains.Count));

        for (int i = 0; i < length; i++)
        {
            sentence.Add(currentToken);
            List<string> possibleNextTokens = chains[currentToken];
            currentToken = possibleNextTokens[rand.Next(possibleNextTokens.Count)];
        }

        sentence.Add(currentToken);

        return string.Join(" ", sentence);
    }
}

class Program
{
    static void Main()
    {
        MarkovChain chain = new MarkovChain();

        chain.AddToken("The", "quick");
        chain.AddToken("quick", "brown");
        chain.AddToken("brown", "fox");
        chain.AddToken("fox", "jumps");
        chain.AddToken("jumps", "over");
        chain.AddToken("over", "the");
        chain.AddToken("the", "lazy");
        chain.AddToken("lazy", "dog");

        string sentence = chain.GenerateSentence(8);
        Console.WriteLine(sentence);
    }
}
