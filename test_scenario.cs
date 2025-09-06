
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.IO;

namespace PDFTextExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string pdfFilePath = @"path_to_your_pdf_file.pdf";

            using (PdfReader reader = new PdfReader(pdfFilePath))
            {
                for (int page = 1; page <= reader.NumberOfPages; page++)
                {
                    string text = PdfTextExtractor.GetTextFromPage(reader, page, new SimpleTextExtractionStrategy());
                    Console.WriteLine($"Page {page}:\n{text}\n");
                }
            }
        }
    }
}
