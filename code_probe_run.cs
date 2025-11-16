
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System;
using System.IO;

namespace PdfTextExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string pdfFilePath = "example.pdf";

            try
            {
                using (PdfReader reader = new PdfReader(pdfFilePath))
                {
                    for (int i = 1; i <= reader.NumberOfPages; i++)
                    {
                        string text = PdfTextExtractor.GetTextFromPage(reader, i);
                        Console.WriteLine(text);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred: " + e.Message);
            }
        }
    }
}
