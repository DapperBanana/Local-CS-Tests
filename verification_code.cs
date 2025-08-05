
using System;
using DlibDotNet;
using DlibDotNet.Extensions;
using DlibDotNet.ImageTransforms;

namespace FaceRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            var faceDetector = Dlib.GetFrontalFaceDetector();
            var shapePredictor = ShapePredictor.Deserialize("shape_predictor_68_face_landmarks.dat");
            var faceRecognition = Dlib.GetFaceRecognition();

            var img = Dlib.LoadImageAsMatrix<RgbPixel>("test.jpg");
            var faces = faceDetector.Operator(img);
            var shapes = new FullObjectDetection[faces.Length];

            foreach (var face in faces)
            {
                shapes[0] = shapePredictor.Operator(img, face);
                var faceDescriptor = faceRecognition.ComputeFaceDescriptor(img, shapes[0]);
                // You can now compare this face descriptor with other face descriptors using e.g. Euclidean distance
                Console.WriteLine($"Face descriptor: {faceDescriptor}");
            }
        }
    }
}
