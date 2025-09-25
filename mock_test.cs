
using System;
using OpenCvSharp;

class Program
{
    static void Main(string[] args)
    {
        // Read an image from file
        Mat image = Cv2.ImRead("image.jpg");

        // Convert the image to grayscale
        Mat grayImage = new Mat();
        Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

        // Perform thresholding to create a binary image
        Mat binaryImage = new Mat();
        Cv2.Threshold(grayImage, binaryImage, 0, 255, ThresholdTypes.Binary | ThresholdTypes.Otsu);

        // Find contours in the binary image
        Cv2.FindContours(binaryImage, out Point[][] contours, out HierarchyIndex[] hierarchy, RetrievalModes.List, ContourApproximationModes.ApproxSimple);
        
        // Draw contours on the original image
        Cv2.DrawContours(image, contours, -1, Scalar.Red, 2);

        // Display the segmented image
        Cv2.ImShow("Segmented Image", image);
        Cv2.WaitKey();
    }
}
