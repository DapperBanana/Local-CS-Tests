
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        Bitmap image = new Bitmap("input.jpg");
        Bitmap grayImage = ToGrayscale(image);
        grayImage.Save("output.jpg");
    }

    static Bitmap ToGrayscale(Bitmap image)
    {
        Bitmap grayImage = new Bitmap(image.Width, image.Height);

        for (int x = 0; x < image.Width; x++)
        {
            for (int y = 0; y < image.Height; y++)
            {
                Color pixel = image.GetPixel(x, y);
                int grayValue = (int)((pixel.R * 0.3) + (pixel.G * 0.59) + (pixel.B * 0.11));
                Color grayPixel = Color.FromArgb(grayValue, grayValue, grayValue);
                grayImage.SetPixel(x, y, grayPixel);
            }
        }

        return grayImage;
    }
}
