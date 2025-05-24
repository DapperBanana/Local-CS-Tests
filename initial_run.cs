
using OpenCvSharp;

class Program
{
    static void Main(string[] args)
    {
        // Load an image
        Mat image = Cv2.ImRead("input_image.jpg", ImreadModes.Color);

        // Convert the image to grayscale
        Mat grayImage = new Mat();
        Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

        // Apply Gaussian blur to the grayscale image
        Mat blurredImage = new Mat();
        Cv2.GaussianBlur(grayImage, blurredImage, new Size(5, 5), 0);

        // Use adaptive thresholding to segment the image
        Mat segmentedImage = new Mat();
        Cv2.AdaptiveThreshold(blurredImage, segmentedImage, 255, AdaptiveThresholdTypes.MeanC, ThresholdTypes.Binary, 11, 2);

        // Display the segmented image
        Cv2.ImShow("Segmented Image", segmentedImage);
        Cv2.WaitKey(0);
    }
}
