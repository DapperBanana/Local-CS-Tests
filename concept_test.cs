
using iTextSharp.text.pdf;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "example.pdf";

        using (PdfReader reader = new PdfReader(filePath))
        {
            string text = "";

            for (int i = 1; i <= reader.NumberOfPages; i++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, i);
            }

            Console.WriteLine(text);
        }
    }
}
