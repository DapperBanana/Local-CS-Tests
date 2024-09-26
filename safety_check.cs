
using QRCoder;
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the text to convert to QR code:");
        string input = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);

        Bitmap qrCodeImage = qrCode.GetGraphic(20);
        qrCodeImage.Save("qrcode.png", System.Drawing.Imaging.ImageFormat.Png);

        Console.WriteLine("QR code generated and saved as 'qrcode.png'");
    }
}
