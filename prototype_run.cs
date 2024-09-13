
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int width = 500;
        int height = 500;

        // Create a new bitmap image
        Bitmap image = new Bitmap(width, height);
        
        // Create a Graphics object to draw on the image
        Graphics graphics = Graphics.FromImage(image);

        // Generate a random color for the background
        Color backgroundColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

        // Fill the image with the random background color
        graphics.Clear(backgroundColor);

        // Generate random shapes and colors on the image
        for (int i = 0; i < 100; i++)
        {
            int x = random.Next(width);
            int y = random.Next(height);
            int size = random.Next(20, 100);
            Color shapeColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));

            graphics.FillEllipse(new SolidBrush(shapeColor), x, y, size, size);
        }

        // Save the image to a file
        image.Save("random_image.png", ImageFormat.Png);

        // Clean up resources
        graphics.Dispose();
        image.Dispose();
    }
}
