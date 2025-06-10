
using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        string inputFile = "input.txt";
        string compressedFile = "compressed.gz";
        string decompressedFile = "decompressed.txt";

        Compress(inputFile, compressedFile);
        Decompress(compressedFile, decompressedFile);

        Console.WriteLine("File compression and decompression complete.");
    }

    static void Compress(string inputFile, string compressedFile)
    {
        using (FileStream fs = File.OpenRead(inputFile))
        {
            using (FileStream compressedFileStream = File.Create(compressedFile))
            {
                using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                {
                    fs.CopyTo(compressionStream);
                }
            }
        }
    }

    static void Decompress(string compressedFile, string decompressedFile)
    {
        using (FileStream compressedFileStream = File.OpenRead(compressedFile))
        {
            using (FileStream decompressedFileStream = File.Create(decompressedFile))
            {
                using (GZipStream decompressionStream = new GZipStream(compressedFileStream, CompressionMode.Decompress))
                {
                    decompressionStream.CopyTo(decompressedFileStream);
                }
            }
        }
    }
}
