
using System;
using System.Drawing;

class ImageProcessing
{
    static void Main()
    {
        // Load an image file
        Bitmap image = new Bitmap("image.jpg");

        // Convert the image to grayscale
        Bitmap grayscaleImage = ConvertToGrayscale(image);

        // Save the grayscale image
        grayscaleImage.Save("grayscale_image.jpg");

        Console.WriteLine("Image converted to grayscale successfully.");
    }

    static Bitmap ConvertToGrayscale(Bitmap image)
    {
        Bitmap grayscaleImage = new Bitmap(image.Width, image.Height);

        for (int x = 0; x < image.Width; x++)
        {
            for (int y = 0; y < image.Height; y++)
            {
                Color pixel = image.GetPixel(x, y);
                int grayscaleValue = (int)(pixel.R * 0.3 + pixel.G * 0.59 + pixel.B * 0.11);
                Color grayscalePixel = Color.FromArgb(grayscaleValue, grayscaleValue, grayscaleValue);
                
                grayscaleImage.SetPixel(x, y, grayscalePixel);
            }
        }

        return grayscaleImage;
    }
}
