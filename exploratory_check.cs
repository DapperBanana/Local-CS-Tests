
using iTextSharp.text.pdf;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        ExtractTextFromPdf("example.pdf");
    }

    static void ExtractTextFromPdf(string pdfPath)
    {
        using (PdfReader reader = new PdfReader(pdfPath))
        {
            string text = "";
            for (int i = 1; i <= reader.NumberOfPages; i++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, i);
            }

            Console.WriteLine("Extracted text content:");
            Console.WriteLine(text);
        }
    }
}
