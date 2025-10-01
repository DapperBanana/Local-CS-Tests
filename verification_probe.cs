
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";

        // Read the contents of the input file
        string inputText = File.ReadAllText(inputFilePath);

        // Compress the input text using run-length encoding
        string compressedText = Compress(inputText);

        // Write the compressed text to the output file
        File.WriteAllText(outputFilePath, compressedText);

        Console.WriteLine("File compression successful");
    }

    static string Compress(string input)
    {
        string compressedText = "";
        char currentChar = input[0];
        int count = 1;

        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == currentChar)
            {
                count++;
            }
            else
            {
                compressedText += currentChar + count.ToString();
                currentChar = input[i];
                count = 1;
            }
        }

        // Add the last character count
        compressedText += currentChar + count.ToString();

        return compressedText;
    }
}
