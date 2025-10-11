
using System;
using System.Drawing;

namespace RandomImageGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new random instance
            Random rand = new Random();

            // Set the size of the image
            int width = 500;
            int height = 500;

            // Create a new bitmap with the specified size
            Bitmap bmp = new Bitmap(width, height);

            // Loop through each pixel in the image
            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    // Generate a random color
                    Color color = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));

                    // Set the color of the current pixel
                    bmp.SetPixel(x, y, color);
                }
            }

            // Save the image to a file
            bmp.Save("random_image.bmp");

            // Display a message to the user
            Console.WriteLine("Random image generated successfully!");
        }
    }
}
