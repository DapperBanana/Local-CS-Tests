
using System;
using System.Drawing;

class ImageProcessing
{
    static void Main()
    {
        // Load an image file
        Bitmap originalImage = new Bitmap("inputImage.jpg");

        // Create a new image with the same dimensions
        Bitmap grayscaleImage = new Bitmap(originalImage.Width, originalImage.Height);

        // Convert the image to grayscale
        for (int y = 0; y < originalImage.Height; y++)
        {
            for (int x = 0; x < originalImage.Width; x++)
            {
                Color pixel = originalImage.GetPixel(x, y);

                int grayValue = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                Color grayPixel = Color.FromArgb(grayValue, grayValue, grayValue);

                grayscaleImage.SetPixel(x, y, grayPixel);
            }
        }

        // Save the grayscale image
        grayscaleImage.Save("outputImage.jpg");

        Console.WriteLine("Image processing complete.");
    }
}
