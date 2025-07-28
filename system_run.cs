
using System;
using System.Drawing;

class ImageProcessing
{
    static void Main()
    {
        Bitmap image = new Bitmap("input.jpg");

        for (int x = 0; x < image.Width; x++)
        {
            for (int y = 0; y < image.Height; y++)
            {
                Color pixel = image.GetPixel(x, y);
                int grayscale = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                Color newPixel = Color.FromArgb(grayscale, grayscale, grayscale);
                image.SetPixel(x, y, newPixel);
            }
        }

        image.Save("output.jpg");

        Console.WriteLine("Grayscale conversion complete.");
    }
}
