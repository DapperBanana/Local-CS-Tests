
using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Python script to generate a random image
        string pythonScript = @"
import random
from PIL import Image, ImageDraw

# Define the size of the image
width = 500
height = 500

# Create a new image
img = Image.new('RGB', (width, height))

# Create a draw object
draw = ImageDraw.Draw(img)

# Generate random pixels
for x in range(width):
    for y in range(height):
        r = random.randint(0, 255)
        g = random.randint(0, 255)
        b = random.randint(0, 255)
        draw.point((x, y), fill=(r, g, b))

# Save the image
img.save('random_image.png')
";

        // Run the Python script
        ProcessStartInfo start = new ProcessStartInfo();
        start.FileName = "python";
        start.Arguments = "-c \"" + pythonScript + "\"";
        start.UseShellExecute = false;
        start.CreateNoWindow = true;
        start.RedirectStandardOutput = true;

        using (Process process = Process.Start(start))
        {
            using (StreamReader reader = process.StandardOutput)
            {
                string result = reader.ReadToEnd();
                Console.WriteLine(result);
            }
        }

        Console.WriteLine("Random image generated successfully!");
    }
}
