
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        Bitmap image = new Bitmap("example.jpg");

        GrayscaleConverter grayscaleConverter = new GrayscaleConverter();
        Bitmap grayscaleImage = grayscaleConverter.ConvertToGrayscale(image);

        grayscaleImage.Save("grayscale.jpg");

        Console.WriteLine("Grayscale conversion completed.");
    }
}

class GrayscaleConverter
{
    public Bitmap ConvertToGrayscale(Bitmap image)
    {
        Bitmap grayscaleImage = new Bitmap(image.Width, image.Height);

        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                Color pixelColor = image.GetPixel(x, y);
                int grayscaleValue = (int)(pixelColor.R * 0.3 + pixelColor.G * 0.59 + pixelColor.B * 0.11);

                Color newColor = Color.FromArgb(grayscaleValue, grayscaleValue, grayscaleValue);
                grayscaleImage.SetPixel(x, y, newColor);
            }
        }

        return grayscaleImage;
    }
}
