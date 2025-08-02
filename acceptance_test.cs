
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "sample.csv";

        if (File.Exists(filePath))
        {
            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        else
        {
            Console.WriteLine("File not found: " + filePath);
        }
    }
}
