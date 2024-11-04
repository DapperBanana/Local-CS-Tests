
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string pdfFilePath = "example.pdf";

        using (PdfReader reader = new PdfReader(pdfFilePath))
        {
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                string text = PdfTextExtractor.GetTextFromPage(reader, page);
                Console.WriteLine("Page " + page + ":");
                Console.WriteLine(text);
            }
        }
    }
}
