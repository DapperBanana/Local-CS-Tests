
using System;
using Python.Runtime;

namespace RandomImageGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Py.GIL())
            {
                dynamic pillow = Py.Import("PIL.Image");

                // Generate a random image with size 100x100
                dynamic image = pillow.new("RGB", new PyTuple(new dynamic[] { 100, 100 }));
                dynamic pixels = image.load();

                Random random = new Random();
                for (int i = 0; i < 100; i++)
                {
                    for (int j = 0; j < 100; j++)
                    {
                        pixels[i, j] = new PyTuple(new dynamic[] { random.Next(0, 256), random.Next(0, 256), random.Next(0, 256) });
                    }
                }

                // Save the image to a file
                image.save("random_image.png", "PNG");

                Console.WriteLine("Random image generated and saved as random_image.png");
            }
        }
    }
}
