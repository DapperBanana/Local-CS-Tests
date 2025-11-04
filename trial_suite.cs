
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";
        
        CompressFile(inputFilePath, outputFilePath);
        
        Console.WriteLine("File compressed successfully.");
    }

    static void CompressFile(string inputFilePath, string outputFilePath)
    {
        using (var inputFile = File.OpenText(inputFilePath))
        using (var outputFile = File.CreateText(outputFilePath))
        {
            char prevChar = (char)inputFile.Read();
            int count = 1;

            int nextChar;
            while ((nextChar = inputFile.Read()) != -1)
            {
                if (nextChar == prevChar)
                {
                    count++;
                }
                else
                {
                    outputFile.Write($"{count}{prevChar}");
                    prevChar = (char)nextChar;
                    count = 1;
                }
            }

            outputFile.Write($"{count}{prevChar}");
        }
    }
}
