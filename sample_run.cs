
using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Enter the text to encode as QR code: ");
        string inputText = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(inputText, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);

        Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.Black, Color.White, true);
        qrCodeImage.Save("qrcode.png", ImageFormat.Png);

        Console.WriteLine("QR code generated successfully and saved as 'qrcode.png'.");
    }
}
