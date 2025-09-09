
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

class Program
{
    static void Main()
    {
        string filePath = "image.jpg"; // Path to the image file

        Image img = Image.FromFile(filePath);

        PropertyItem[] propItems = img.PropertyItems;

        StringBuilder sb = new StringBuilder();

        foreach (PropertyItem propItem in propItems)
        {
            sb.Append($"ID: {propItem.Id}, Type: {propItem.Type}, Length: {propItem.Len}, Value: ");

            // Handle different types of metadata values
            switch (propItem.Type)
            {
                case 2: // ASCII
                    sb.Append(Encoding.ASCII.GetString(propItem.Value));
                    break;
                case 3: // Short
                    sb.Append(BitConverter.ToInt16(propItem.Value, 0));
                    break;
                case 4: // Long
                    sb.Append(BitConverter.ToInt32(propItem.Value, 0));
                    break;
                case 5: // Rational
                    sb.Append(BitConverter.ToInt32(propItem.Value, 0) / BitConverter.ToInt32(propItem.Value, 4));
                    break;
                default:
                    sb.Append("[Unsupported metadata type]");
                    break;
            }

            sb.AppendLine();
        }

        Console.WriteLine(sb.ToString());

        img.Dispose();
    }
}
