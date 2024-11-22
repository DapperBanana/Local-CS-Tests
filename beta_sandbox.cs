
using QRCoder;
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        Console.Write("Enter the text for the QR code: ");
        string input = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        QRCode qrCode = new QRCode(qrCodeData);

        Bitmap qrCodeImage = qrCode.GetGraphic(20, Color.Black, Color.White, true);

        qrCodeImage.Save("qrcode.jpg", ImageFormat.Jpeg);

        Console.WriteLine("QR code generated successfully!");
    }
}
