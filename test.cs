
using iTextSharp.text.pdf;
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string pdfFilePath = "example.pdf";

        using (PdfReader reader = new PdfReader(pdfFilePath))
        {
            string text = "";

            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text += PdfTextExtractor.GetTextFromPage(reader, page);
            }

            Console.WriteLine(text);
        }
    }
}
