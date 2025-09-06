
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        string imagePath = "image.jpg";
        Bitmap image = new Bitmap(imagePath);

        GrayscaleConversion(image);

        image.Save("grayscale_image.jpg");
    }

    static void GrayscaleConversion(Bitmap image)
    {
        for (int x = 0; x < image.Width; x++)
        {
            for (int y = 0; y < image.Height; y++)
            {
                Color pixel = image.GetPixel(x, y);
                int grayscaleValue = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                Color newPixel = Color.FromArgb(grayscaleValue, grayscaleValue, grayscaleValue);
                image.SetPixel(x, y, newPixel);
            }
        }
    }
}
