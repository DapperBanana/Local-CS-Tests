
using QRCoder;
using System;
using System.Drawing;
using System.IO;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the text you want to encode in the QR code:");
        string input = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);

        Bitmap qrCodeImage = qrCode.GetGraphic(20);

        Console.WriteLine("QR code generated successfully!");

        Console.WriteLine("Enter the output file path (e.g. C:\\output.png):");
        string outputPath = Console.ReadLine();

        qrCodeImage.Save(outputPath, System.Drawing.Imaging.ImageFormat.Png);

        Console.WriteLine("QR code saved to: " + outputPath);
    }
}
