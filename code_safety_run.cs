
using System;
using OpenCvSharp;

class ImageSegmentation
{
    static void Main()
    {
        // Load the image
        Mat image = Cv2.ImRead("image.jpg", ImreadModes.Color);

        // Convert the image to grayscale
        Mat grayImage = new Mat();
        Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

        // Apply a threshold to segment the image
        Mat thresholdedImage = new Mat();
        Cv2.Threshold(grayImage, thresholdedImage, 0, 255, ThresholdTypes.Binary | ThresholdTypes.Otsu);

        // Display the segmented image
        Cv2.ImShow("Segmented Image", thresholdedImage);
        Cv2.WaitKey(0);
        Cv2.DestroyAllWindows();
    }
}
