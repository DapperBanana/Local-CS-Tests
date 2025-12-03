using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        string imagePath = "path_to_your_image.jpg"; // Replace with your image path

        try
        {
            using (Image image = Image.FromFile(imagePath))
            {
                Console.WriteLine("Image Format: " + image.RawFormat.ToString());

                // Get image dimensions
                Console.WriteLine("Width: " + image.Width + " pixels");
                Console.WriteLine("Height: " + image.Height + " pixels");

                // Get image resolution
                Console.WriteLine("Horizontal Resolution: " + image.HorizontalResolution + " dpi");
                Console.WriteLine("Vertical Resolution: " + image.VerticalResolution + " dpi");

                // Get image pixel format
                Console.WriteLine("Pixel Format: " + image.PixelFormat.ToString());

                // Extract metadata
                Console.WriteLine("\nMetadata:");
                foreach (PropertyItem propItem in image.PropertyItems)
                {
                    string value = GetPropertyValue(propItem);
                    Console.WriteLine($"Tag ID: {propItem.Id} (Type: {propItem.Type})");
                    Console.WriteLine($"Value: {value}\n");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error reading image: " + ex.Message);
        }
    }

    // Helper method to convert PropertyItem value to readable string
    static string GetPropertyValue(PropertyItem propItem)
    {
        try
        {
            switch (propItem.Type)
            {
                case 1: // BYTE
                    return propItem.Value[0].ToString();
                case 2: // ASCII
                    return Encoding.ASCII.GetString(propItem.Value).Trim('\0');
                case 3: // SHORT (2 bytes)
                    return BitConverter.ToUInt16(propItem.Value, 0).ToString();
                case 4: // LONG (4 bytes)
                    return BitConverter.ToUInt32(propItem.Value, 0).ToString();
                case 5: // RATIONAL
                    {
                        uint numerator = BitConverter.ToUInt32(propItem.Value, 0);
                        uint denominator = BitConverter.ToUInt32(propItem.Value, 4);
                        return $"{numerator}/{denominator}";
                    }
                default:
                    return BitConverter.ToString(propItem.Value);
            }
        }
        catch
        {
            return "Unable to parse value.";
        }
    }
}