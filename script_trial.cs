using System;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;

class Program
{
    static void Main(string[] args)
    {
        string pdfPath = "sample.pdf"; // Path to your PDF file
        string extractedText = ExtractTextFromPdf(pdfPath);
        Console.WriteLine(extractedText);
    }

    public static string ExtractTextFromPdf(string path)
    {
        using (PdfReader reader = new PdfReader(path))
        {
            StringWriter output = new StringWriter();

            for (int i = 1; i <= reader.NumberOfPages; i++)
            {
                string currentText = PdfTextExtractor.GetTextFromPage(reader, i);
                output.WriteLine(currentText);
            }

            return output.ToString();
        }
    }
}