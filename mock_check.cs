
using System;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace PDFTextExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "example.pdf";

            PdfReader pdfReader = new PdfReader(filePath);
            string text = "";

            for (int page = 1; page <= pdfReader.NumberOfPages; page++)
            {
                ITextExtractionStrategy strategy = new SimpleTextExtractionStrategy();
                text += PdfTextExtractor.GetTextFromPage(pdfReader, page, strategy);
            }

            pdfReader.Close();

            Console.WriteLine(text);
        }
    }
}
