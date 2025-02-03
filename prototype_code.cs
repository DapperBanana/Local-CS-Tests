
using DlibDotNet;
using DlibDotNet.Extensions;
using System;
using System.Drawing;

namespace FaceRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the face recognition model
            using (var fd = Dlib.GetFrontalFaceDetector())
            using (var sp = ShapePredictor.Deserialize("shape_predictor_68_face_landmarks.dat"))
            using (var net = Dlib.GetDnnMmodFaceDetectionModel())
            using (var faceRecognizer = Dlib.GetFaceRecognitionNet())
            {
                // Load an image for face recognition
                var image = Dlib.LoadImage<RgbPixel>("test.jpg");

                // Detect faces in the image
                var faces = fd.Operator(image);

                // Iterate over each detected face
                foreach (var face in faces)
                {
                    // Find facial landmarks
                    var shape = sp.Detect(image, face);

                    // Recognize the face
                    var faceDescriptor = faceRecognizer.ComputeFaceDescriptor(image, shape);
                    
                    // Print the face descriptor
                    Console.WriteLine($"Face descriptor: {faceDescriptor}");
                }
            }
        }
    }
}
