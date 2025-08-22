
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFileName = "input.txt";
        string outputFileName = "output.txt";

        CompressFile(inputFileName, outputFileName);

        Console.WriteLine("File compression completed.");
    }

    static void CompressFile(string inputFileName, string outputFileName)
    {
        using (StreamReader reader = new StreamReader(inputFileName))
        using (StreamWriter writer = new StreamWriter(outputFileName))
        {
            char currentChar = (char)reader.Read();
            int count = 1;

            while (!reader.EndOfStream)
            {
                char nextChar = (char)reader.Read();

                if (nextChar == currentChar)
                {
                    count++;
                }
                else
                {
                    writer.Write(count + currentChar);
                    currentChar = nextChar;
                    count = 1;
                }
            }

            writer.Write(count + currentChar);
        }
    }
}
