
using System;
using System.IO;
using System.Text;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

class Program
{
    static void Main()
    {
        string pdfFilePath = "sample.pdf";

        StringBuilder text = new StringBuilder();

        using (PdfReader reader = new PdfReader(pdfFilePath))
        {
            for (int page = 1; page <= reader.NumberOfPages; page++)
            {
                text.Append(PdfTextExtractor.GetTextFromPage(reader, page));
            }
        }

        Console.WriteLine(text.ToString());
    }
}
