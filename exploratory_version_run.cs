
using System;
using System.Text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

namespace PDFTextExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"path_to_pdf_file.pdf";

            StringBuilder text = new StringBuilder();

            using (PdfReader reader = new PdfReader(filePath))
            {
                for (int i = 1; i <= reader.NumberOfPages; i++)
                {
                    text.Append(PdfTextExtractor.GetTextFromPage(reader, i));
                }
            }

            Console.WriteLine(text.ToString());
        }
    }
}
