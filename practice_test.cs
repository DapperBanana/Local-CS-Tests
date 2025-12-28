using System;
using System.Drawing;
using QRCoder;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter text to generate QR code:");
        string inputText = Console.ReadLine();

        // Generate QR code
        using (var generator = new QRCodeGenerator())
        {
            var data = generator.CreateQrCode(inputText, QRCodeGenerator.ECCLevel.Q);
            using (var qrCode = new QRCode(data))
            {
                using (Bitmap bitmap = qrCode.GetGraphic(20))
                {
                    string filePath = "qrcode.png";
                    bitmap.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                    Console.WriteLine($"QR code saved to {filePath}");
                }
            }
        }
    }
}