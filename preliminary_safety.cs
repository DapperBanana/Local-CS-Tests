
using DlibDotNet;
using DlibDotNet.Extensions;
using DlibDotNet.ImageProcess;
using System;

namespace FaceRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the face recognition model
            var faceRecognition = Dlib.GetFrontalFaceDetector();
            var shapePredictor = ShapePredictor.Deserialize("shape_predictor_68_face_landmarks.dat");
            var faceRecognizer = Dlib.GetFaceRecognition();

            // Load the test image
            var image = Dlib.LoadImage<RgbPixel>("test.jpg");

            // Detect faces in the image
            var faces = faceRecognition.Operator(image);

            foreach (var face in faces)
            {
                // Calculate facial landmarks
                var shape = shapePredictor.Detect(image, face);

                // Recognize the face
                var faceDescriptor = faceRecognizer.ComputeFaceDescriptor(image, shape);
                var distance = faceRecognizer.ComputeFaceDescriptorDistance(faceDescriptor, faceDescriptor);

                Console.WriteLine($"Distance: {distance}");
            }
        }
    }
}
