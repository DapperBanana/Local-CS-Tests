
using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the input for the QR code:");
        string input = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);

        Bitmap qrCodeImage = qrCode.GetGraphic(20);

        qrCodeImage.Save("qrcode.png", ImageFormat.Png);
        Console.WriteLine("QR code generated and saved as qrcode.png");
    }
}
