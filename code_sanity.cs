
using System;
using System.IO;

class FileCompression
{
    static void Main()
    {
        string inputFileName = "input.txt";
        string outputFileName = "output.txt";
        
        CompressFile(inputFileName, outputFileName);
        
        Console.WriteLine("File compressed successfully.");
    }
    
    static void CompressFile(string inputFileName, string outputFileName)
    {
        using (StreamReader sr = new StreamReader(inputFileName))
        using (StreamWriter sw = new StreamWriter(outputFileName))
        {
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                
                // Perform compression by removing repeated characters
                string compressedLine = CompressString(line);
                
                // Write the compressed line to the output file
                sw.WriteLine(compressedLine);
            }
        }
    }
    
    static string CompressString(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return input;
        }
        
        string compressed = "";
        char prevChar = input[0];
        int count = 1;
        
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] == prevChar)
            {
                count++;
            }
            else
            {
                compressed += prevChar + count.ToString();
                prevChar = input[i];
                count = 1;
            }
        }
        
        // Add the last character and count
        compressed += prevChar + count.ToString();
        
        return compressed;
    }
}
