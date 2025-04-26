
using System;
using System.IO;

class MainClass {
    public static void Main (string[] args) {
        string filePath = "sample.txt"; // Path to the text file

        string content = File.ReadAllText(filePath);
        int wordCount = CountWords(content);

        Console.WriteLine("The number of words in the file is: " + wordCount);
    }

    public static int CountWords(string text) {
        int wordCount = 0;

        bool inWord = false;
        foreach (char c in text) {
            if (char.IsLetter(c)) {
                inWord = true;
            } else {
                if (inWord) {
                    wordCount++;
                }
                inWord = false;
            }
        }

        if (inWord) {
            wordCount++;
        }

        return wordCount;
    }
}
