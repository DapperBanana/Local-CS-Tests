
using System;

namespace PDFExtractor
{
    class Program
    {
        static void Main(string[] args)
        {
            string pythonScriptPath = "extract_text.py";
            string pdfPath = "sample.pdf";
            
            var psi = new System.Diagnostics.ProcessStartInfo();
            psi.FileName = @"C:\path\to\IronPython\ipy.exe";
            psi.Arguments = $"{pythonScriptPath} {pdfPath}";
            psi.UseShellExecute = false;
            psi.RedirectStandardOutput = true;
            psi.CreateNoWindow = true;

            using (var process = System.Diagnostics.Process.Start(psi))
            {
                process.WaitForExit();
                string extractedText = process.StandardOutput.ReadToEnd();
                Console.WriteLine(extractedText);
            }
        }
    }
}
