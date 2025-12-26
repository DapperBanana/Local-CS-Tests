using System;
using OpenCvSharp;

class ImageSegmentation
{
    static void Main(string[] args)
    {
        // Load the image
        string imagePath = "path_to_your_image.jpg";
        Mat src = Cv2.ImRead(imagePath, ImreadModes.Color);
        if (src.IsEmpty())
        {
            Console.WriteLine("Could not load image.");
            return;
        }

        // Convert to grayscale
        Mat gray = new Mat();
        Cv2.CvtColor(src, gray, ColorConversionCodes.BGR2GRAY);

        // Apply GaussianBlur to reduce noise before segmentation
        Mat blurred = new Mat();
        Cv2.GaussianBlur(gray, blurred, new Size(5, 5), 0);

        // Use Otsu's thresholding to segment the image
        Mat thresholds = new Mat();
        double otsuThreshValue = Cv2.Threshold(blurred, thresholds, 0, 255, ThresholdTypes.Otsu);

        // Create a binary mask based on threshold
        Mat binaryMask = new Mat();
        Cv2.Threshold(blurred, binaryMask, otsuThreshValue, 255, ThresholdTypes.Binary);

        // Optional: Find contours for further processing (e.g., extract regions)
        Point[][] contours;
        HierarchyIndex[] hierarchy;
        Cv2.FindContours(binaryMask, out contours, out hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);

        // Draw contours on the original image
        Mat contourImg = src.Clone();
        Cv2.DrawContours(contourImg, contours, -1, Scalar.Red, 2);

        // Save the segmentation result
        Cv2.ImWrite("segmented_output.png", contourImg);

        // Display images if needed
        // Cv2.ImShow("Original", src);
        // Cv2.ImShow("Binary Mask", binaryMask);
        // Cv2.ImShow("Contours", contourImg);
        // Cv2.WaitKey();

        Console.WriteLine("Segmentation completed. Output saved to segmented_output.png");
    }
}