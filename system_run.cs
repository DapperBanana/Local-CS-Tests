
using System;
using System.Drawing;

class ImageProcessing
{
    static void Main()
    {
        // Load an image file
        Bitmap image = new Bitmap("image.jpg");

        // Convert the image to grayscale
        Bitmap grayImage = ConvertToGrayscale(image);

        // Save the grayscale image
        grayImage.Save("grayscale_image.jpg");

        Console.WriteLine("Image processing complete. Press any key to exit.");
        Console.ReadKey();
    }

    static Bitmap ConvertToGrayscale(Bitmap image)
    {
        Bitmap grayImage = new Bitmap(image.Width, image.Height);

        for (int y = 0; y < image.Height; y++)
        {
            for (int x = 0; x < image.Width; x++)
            {
                Color pixel = image.GetPixel(x, y);

                int avgValue = (pixel.R + pixel.G + pixel.B) / 3;

                Color newPixel = Color.FromArgb(avgValue, avgValue, avgValue);

                grayImage.SetPixel(x, y, newPixel);
            }
        }

        return grayImage;
    }
}
