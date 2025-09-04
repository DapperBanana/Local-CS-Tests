
using System;
using QRCoder;
using System.Drawing;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the text for which you want to generate QR code:");
        string input = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);

        Bitmap qrCodeImage = qrCode.GetGraphic(10);
        qrCodeImage.Save("QRCode.png", System.Drawing.Imaging.ImageFormat.Png);

        Console.WriteLine("QR code generated successfully!");
    }
}
