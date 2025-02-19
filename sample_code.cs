
using OpenCvSharp;

class Program
{
    static void Main()
    {
        // Load an image
        Mat image = Cv2.ImRead("image.jpg", ImreadModes.Color);

        // Convert the image to grayscale
        Mat grayImage = new Mat();
        Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

        // Perform segmentation using Otsu's thresholding
        Mat binaryImage = new Mat();
        Cv2.Threshold(grayImage, binaryImage, 0, 255, ThresholdTypes.Binary | ThresholdTypes.Otsu);

        // Display the segmented image
        Cv2.ImShow("Segmented Image", binaryImage);
        Cv2.WaitKey(0);
    }
}
