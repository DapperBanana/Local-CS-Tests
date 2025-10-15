
using QRCoder;
using System;
using System.Drawing;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the text to generate QR code:");
        string input = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);

        Bitmap qrCodeImage = qrCode.GetGraphic(20);

        Console.WriteLine("QR code generated successfully!");

        SaveQRCodeImage(qrCodeImage);
    }

    static void SaveQRCodeImage(Bitmap qrCodeImage)
    {
        string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "QRCode.png");
        qrCodeImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);

        Console.WriteLine($"QR code image saved to: {filePath}");
    }
}
