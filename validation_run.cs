
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Text;

class Program
{
    static void Main()
    {
        string imagePath = "image.jpg";
        Image image = Image.FromFile(imagePath);

        // Get metadata properties
        PropertyItem[] propItems = image.PropertyItems;

        StringBuilder sb = new StringBuilder();
        foreach (PropertyItem propItem in propItems)
        {
            string propName = propItem.Id.ToString("X");
            string propValue = Encoding.UTF8.GetString(propItem.Value);

            sb.AppendLine($"{propName}: {propValue}");
        }

        Console.WriteLine(sb.ToString());
    }
}
