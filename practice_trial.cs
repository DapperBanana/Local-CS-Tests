
using System;
using System.Drawing;

class Program
{
    static void Main()
    {
        // Load an image from file
        Bitmap image = new Bitmap("input.jpg");

        // Convert the image to grayscale
        Bitmap grayscaleImage = ToGrayscale(image);

        // Save the grayscale image to file
        grayscaleImage.Save("output.jpg");

        Console.WriteLine("Grayscale conversion completed.");
    }

    static Bitmap ToGrayscale(Bitmap image)
    {
        Bitmap grayscaleImage = new Bitmap(image.Width, image.Height);

        for (int x = 0; x < image.Width; x++)
        {
            for (int y = 0; y < image.Height; y++)
            {
                Color color = image.GetPixel(x, y);
                int grayscaleValue = (int)(color.R * 0.3 + color.G * 0.59 + color.B * 0.11);
                Color grayscaleColor = Color.FromArgb(grayscaleValue, grayscaleValue, grayscaleValue);
                grayscaleImage.SetPixel(x, y, grayscaleColor);
            }
        }

        return grayscaleImage;
    }
}
