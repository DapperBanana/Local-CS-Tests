
using System;
using OpenCvSharp;
using OpenCvSharp.Extensions;

class Program
{
    static void Main()
    {
        // Load the image
        using (Mat image = new Mat("input_image.jpg"))
        {
            // Convert the image to grayscale
            Mat grayImage = new Mat();
            Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

            // Apply thresholding to segment the image
            Mat binaryImage = new Mat();
            Cv2.Threshold(grayImage, binaryImage, 127, 255, ThresholdTypes.Binary);

            // Display the segmented image
            using (Window window = new Window("Segmented Image", image: binaryImage))
            {
                Cv2.WaitKey();
            }
        }
    }
}
