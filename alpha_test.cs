
using OpenCvSharp;
using OpenCvSharp.Extensions;

class Program
{
    static void Main(string[] args)
    {
        Mat image = new Mat("input_image.jpg", ImreadModes.Color);

        Mat grayImage = new Mat();
        Cv2.CvtColor(image, grayImage, ColorConversionCodes.BGR2GRAY);

        Mat binaryImage = new Mat();
        Cv2.Threshold(grayImage, binaryImage, 0, 255, ThresholdTypes.Binary | ThresholdTypes.Otsu);

        Mat[] contours;
        Mat hierarchy = new Mat();
        Cv2.FindContours(binaryImage, out contours, hierarchy, RetrievalModes.External, ContourApproximationModes.ApproxSimple);

        Mat segmentedImage = Mat.Zeros(image.Size(), MatType.CV_8UC3);
        for (int i = 0; i < contours.Length; i++)
        {
            Scalar color = Scalar.RandomColor();
            Cv2.DrawContours(segmentedImage, contours, i, color, -1);
        }

        segmentedImage.SaveImage("segmented_image.jpg");
    }
}
