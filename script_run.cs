
using OpenCvSharp;

class Program
{
    static void Main()
    {
        Mat image = Cv2.ImRead("input.jpg", ImreadModes.Color);

        Mat gray = new Mat();
        Cv2.CvtColor(image, gray, ColorConversionCodes.BGR2GRAY);

        Mat binary = new Mat();
        Cv2.Threshold(gray, binary, 127, 255, ThresholdTypes.Binary);

        Cv2.ImShow("Input Image", image);
        Cv2.ImShow("Segmented Image", binary);

        Cv2.WaitKey();
    }
}
