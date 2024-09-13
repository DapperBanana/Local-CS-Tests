
using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace RandomImageGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a random number generator
            Random random = new Random();
            
            // Create a new Bitmap object with dimensions 500x500
            Bitmap bmp = new Bitmap(500, 500);
            
            // Get the bitmap's Graphics object
            Graphics graphics = Graphics.FromImage(bmp);

            // Generate random values for the image
            int red = random.Next(256);
            int green = random.Next(256);
            int blue = random.Next(256);

            // Generate a random color
            Color color = Color.FromArgb(red, green, blue);

            // Fill the whole image with the random color
            graphics.FillRectangle(new SolidBrush(color), 0, 0, bmp.Width, bmp.Height);

            // Save the generated image
            bmp.Save("random_image.jpg", ImageFormat.Jpeg);

            // Display a message to the user
            Console.WriteLine("Random image generated successfully. Image saved as 'random_image.jpg'");
        }
    }
}
