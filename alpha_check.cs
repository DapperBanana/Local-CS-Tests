
using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        string inputFile = "input.txt";
        string compressedFile = "compressedFile.txt";
        string decompressedFile = "decompressedFile.txt";

        CompressFile(inputFile, compressedFile);
        DecompressFile(compressedFile, decompressedFile);
    }

    static void CompressFile(string inputFile, string compressedFile)
    {
        using (FileStream fs = new FileStream(inputFile, FileMode.Open))
        {
            using (FileStream compressedFileStream = File.Create(compressedFile))
            {
                using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                {
                    fs.CopyTo(compressionStream);
                    Console.WriteLine($"File {inputFile} compressed to {compressedFile}");
                }
            }
        }
    }

    static void DecompressFile(string compressedFile, string decompressedFile)
    {
        using (FileStream compressedFileStream = new FileStream(compressedFile, FileMode.Open))
        {
            using (GZipStream decompressionStream = new GZipStream(compressedFileStream, CompressionMode.Decompress))
            {
                using (FileStream decompressedFileStream = File.Create(decompressedFile))
                {
                    decompressionStream.CopyTo(decompressedFileStream);
                    Console.WriteLine($"File {compressedFile} decompressed to {decompressedFile}");
                }
            }
        }
    }
}
