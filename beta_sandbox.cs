
using System;
using System.IO;
using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "textfile.txt";
        string keyword = "oldWord";
        string replacement = "newWord";

        // Read the contents of the file
        string fileContents = File.ReadAllText(filePath);

        // Replace the keyword with the replacement in the file contents
        fileContents = fileContents.Replace(keyword, replacement);

        // Write the updated contents back to the file
        File.WriteAllText(filePath, fileContents);

        Console.WriteLine("The word has been replaced successfully.");
    }
}
