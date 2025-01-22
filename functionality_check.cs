
using System;
using System.Drawing;
using System.Drawing.Imaging;

class ImageProcessing
{
    static void Main()
    {
        string imagePath = "input.jpg";
        string outputPath = "output.jpg";

        Bitmap image = new Bitmap(imagePath);

        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                Color pixel = image.GetPixel(x, y);
                int grayscale = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                Color newPixel = Color.FromArgb(grayscale, grayscale, grayscale);
                image.SetPixel(x, y, newPixel);
            }
        }

        image.Save(outputPath, ImageFormat.Jpeg);
        Console.WriteLine("Grayscale conversion complete. Image saved as output.jpg.");
    }
}
