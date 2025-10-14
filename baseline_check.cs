
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Image = System.Drawing.Image;

class Program
{
    static void Main()
    {
        // Generate a random image
        Bitmap image = new Bitmap(500, 500);
        Random random = new Random();

        for (int x = 0; x < image.Width; x++)
        {
            for (int y = 0; y < image.Height; y++)
            {
                Color randomColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
                image.SetPixel(x, y, randomColor);
            }
        }

        // Save the image to a file
        string filePath = "random_image.jpg";
        image.Save(filePath, ImageFormat.Jpeg);

        // Display the image
        Image displayImage = Image.FromFile(filePath);
        displayImage.Show();
    }
}

public static class ImageExtensions
{
    public static void Show(this Image image)
    {
        using (MemoryStream ms = new MemoryStream())
        {
            image.Save(ms, ImageFormat.Jpeg);
            byte[] bytes = ms.ToArray();

            using (MemoryStream ms2 = new MemoryStream(bytes))
            {
                Image displayImage = Image.FromStream(ms2);
                displayImage.Show();
            }
        }
    }
}
