
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Collections;

class ImageMetadataExtractor
{
    static void Main()
    {
        string imagePath = "image.jpg";
        
        using (Image image = Image.FromFile(imagePath))
        {
            PropertyItem[] propItems = image.PropertyItems;
            
            Console.WriteLine("Image Metadata:");
            foreach (PropertyItem propItem in propItems)
            {
                Console.WriteLine($"ID: {propItem.Id}, Type: {propItem.Type}, Length: {propItem.Len}");
                
                // Decode the property item value based on the type
                string value = "";
                switch ((int)propItem.Type)
                {
                    case 2: // ASCII string
                        value = System.Text.Encoding.ASCII.GetString(propItem.Value);
                        break;
                    case 3: // Short
                        value = BitConverter.ToUInt16(propItem.Value, 0).ToString();
                        break;
                    case 4: // Long
                        value = BitConverter.ToUInt32(propItem.Value, 0).ToString();
                        break;
                    case 5: // Rational
                        byte[] numerator = new byte[4] { propItem.Value[0], propItem.Value[1], propItem.Value[2], propItem.Value[3] };
                        byte[] denominator = new byte[4] { propItem.Value[4], propItem.Value[5], propItem.Value[6], propItem.Value[7] };
                        value = $"{BitConverter.ToUInt32(numerator, 0)}/{BitConverter.ToUInt32(denominator, 0)}";
                        break;
                    default:
                        value = "Unknown data type";
                        break;
                }
                
                Console.WriteLine($"Value: {value}");
                Console.WriteLine();
            }
        }
    }
}
