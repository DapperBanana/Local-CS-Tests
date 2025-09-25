
using System;
using QRCoder;

class Program
{
    static void Main()
    {
        Console.Write("Enter the text to encode into QR code: ");
        string input = Console.ReadLine();

        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.H);
        QRCode qrCode = new QRCode(qrCodeData);
        Bitmap qrCodeImage = qrCode.GetGraphic(20);

        qrCodeImage.Save("QRCode.png", System.Drawing.Imaging.ImageFormat.Png);

        Console.WriteLine("QR code generated successfully and saved as QRCode.png");
    }
}
