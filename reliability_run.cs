
using System;
using System.Drawing;
using System.Drawing.Imaging;

class Program
{
    static void Main()
    {
        string imagePath = "image.jpg"; // Replace this with the path to your image file

        using (Image img = Image.FromFile(imagePath))
        {
            foreach (PropertyItem propItem in img.PropertyItems)
            {
                Console.WriteLine($"ID: {propItem.Id.ToString("x")}");
                Console.WriteLine($"Type: {propItem.Type}");
                Console.WriteLine($"Length: {propItem.Len}");

                string value = "";
                switch (propItem.Type)
                {
                    case 2: // ASCII
                        value = System.Text.Encoding.ASCII.GetString(propItem.Value);
                        break;
                    case 3: // SHORT
                        value = BitConverter.ToUInt16(propItem.Value, 0).ToString();
                        break;
                    case 4: // LONG
                        value = BitConverter.ToUInt32(propItem.Value, 0).ToString();
                        break;
                    case 5: // RATIONAL
                        value = BitConverter.ToUInt32(propItem.Value, 0).ToString() + "/" + BitConverter.ToUInt32(propItem.Value, 4).ToString();
                        break;
                    default:
                        value = "Unknown type";
                        break;
                }

                Console.WriteLine($"Value: {value}");
                Console.WriteLine();
            }
        }
    }
}
