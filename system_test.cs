
using System;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace PdfTextExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string pdfFilePath = "example.pdf";
            
            using (PdfReader reader = new PdfReader(pdfFilePath))
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
}
