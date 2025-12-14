using System;
using System.Drawing;
using QRCoder;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the text or URL to encode as QR code:");
        string input = Console.ReadLine();

        // Generate QR code
        QRCodeGenerator qrGenerator = new QRCodeGenerator();
        QRCodeData qrCodeData = qrGenerator.CreateQrCode(input, QRCodeGenerator.ECCLevel.Q);
        using (QRCode qrCode = new QRCode(qrCodeData))
        {
            Bitmap qrCodeImage = qrCode.GetGraphic(20);

            // Save the QR code image
            string filePath = "qrcode.png";
            qrCodeImage.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
            Console.WriteLine($"QR code saved to {filePath}");
        }
    }
}