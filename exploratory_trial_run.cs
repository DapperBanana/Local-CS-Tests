
using QRCoder;
using System;
using System.Drawing;

class QRCodeGenerator
{
    static void Main()
    {
        Console.Write("Enter text to generate QR code: ");
        string text = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(text, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);
        Bitmap qrCodeImage = qrCode.GetGraphic(20);

        qrCodeImage.Save("QRCode.png", System.Drawing.Imaging.ImageFormat.Png);

        Console.WriteLine("QR code saved as QRCode.png");
    }
}
