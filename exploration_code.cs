
using System;
using QRCoder;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the text for the QR code:");
        string input = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);

        Bitmap qrCodeImage = qrCode.GetGraphic(20);
        qrCodeImage.Save("qrcode.png", System.Drawing.Imaging.ImageFormat.Png);

        Console.WriteLine("QR code generated successfully!");
    }
}
