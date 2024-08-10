
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        // Load the image
        Bitmap image = new Bitmap(@"path_to_your_image.jpg");

        // Perform grayscale conversion
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

        // Save the grayscale image
        image.Save(@"path_to_save_grayscale_image.jpg", ImageFormat.Jpeg);

        Console.WriteLine("Grayscale conversion completed. Press any key to exit.");
        Console.ReadKey();
    }
}
