
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        // Create a new bitmap with random dimensions
        Random random = new Random();
        int width = random.Next(100, 500);
        int height = random.Next(100, 500);
        Bitmap bitmap = new Bitmap(width, height);

        // Generate random pixels for the image
        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                bitmap.SetPixel(x, y, randomColor);
            }
        }

        // Save the image
        bitmap.Save("random_image.jpg", ImageFormat.Jpeg);

        Console.WriteLine("Random image generated and saved successfully.");
    }
}
