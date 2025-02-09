
using System;

class MainClass {
    public static void Main (string[] args) {
        Console.WriteLine ("Enter a sentence:");
        string sentence = Console.ReadLine();

        string[] words = sentence.Split(' ');
        int maxLength = 0;

        foreach(string word in words) {
            if (word.Length > maxLength) {
                maxLength = word.Length;
            }
        }

        Console.WriteLine("Length of the longest word in the sentence: " + maxLength);
    }
}
