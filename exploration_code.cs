
using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        string sourceFile = "source.txt";
        string compressedFile = "compressed.gz";

        CompressFile(sourceFile, compressedFile);

        Console.WriteLine("File compressed successfully.");
    }

    static void CompressFile(string sourceFile, string compressedFile)
    {
        using (FileStream sourceStream = new FileStream(sourceFile, FileMode.Open))
        {
            using (FileStream compressedStream = File.Create(compressedFile))
            {
                using (GZipStream compressStream = new GZipStream(compressedStream, CompressionMode.Compress))
                {
                    sourceStream.CopyTo(compressStream);
                }
            }
        }
    }
}
