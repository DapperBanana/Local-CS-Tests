
using System;
using System.IO;
using System.IO.Compression;

class Program
{
    static void Main()
    {
        string filePath = "sampleFile.txt";
        string compressedFilePath = "compressedFile.txt";

        CompressFile(filePath, compressedFilePath);
        DecompressFile(compressedFilePath, "decompressedFile.txt");
    }

    static void CompressFile(string filePath, string compressedFilePath)
    {
        using (FileStream originalFileStream = new FileStream(filePath, FileMode.Open))
        {
            using (FileStream compressedFileStream = File.Create(compressedFilePath))
            {
                using (GZipStream compressionStream = new GZipStream(compressedFileStream, CompressionMode.Compress))
                {
                    originalFileStream.CopyTo(compressionStream);
                    Console.WriteLine("File Compressed Successfully");
                }
            }
        }
    }

    static void DecompressFile(string compressedFilePath, string decompressedFilePath)
    {
        using (FileStream compressedFileStream = new FileStream(compressedFilePath, FileMode.Open))
        {
            using (FileStream decompressedFileStream = File.Create(decompressedFilePath))
            {
                using (GZipStream decompressionStream = new GZipStream(compressedFileStream, CompressionMode.Decompress))
                {
                    decompressionStream.CopyTo(decompressedFileStream);
                    Console.WriteLine("File Decompressed Successfully");
                }
            }
        }
    }
}
