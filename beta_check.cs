
using DlibDotNet;
using DlibDotNet.Extensions;
using DlibDotNet.ImageTransforms;
using DlibDotNet.Dnn;

namespace FaceRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the pre-trained face recognition model
            using (var net = Dlib.GetFrontalFaceDetector())
            using (var faceRecognitionNet = Dlib.GetFaceRecognitionNet())
            {
                var img = Dlib.LoadImageAsMatrix("test.jpg");

                // Detect faces in the image
                var faces = net.Operator(img);

                foreach (var face in faces)
                {
                    // Get the face descriptor
                    var shape = faceRecognitionNet.Operator(img, face);
                    var faceDescriptor = faceRecognitionNet.ComputeFullObjectDetectionDescriptor(img, shape);

                    // Perform face recognition
                    var distances = new List<double>();
                    foreach (var descriptor in knownDescriptors)
                    {
                        var distance = Dlib.Length(descriptor - faceDescriptor);
                        distances.Add(distance);
                    }

                    // Find the closest match
                    var minDistance = distances.Min();
                    var index = distances.IndexOf(minDistance);
                    var label = labels[index];

                    Console.WriteLine($"Detected face with label: {label}");
                }
            }
        }
    }
}
