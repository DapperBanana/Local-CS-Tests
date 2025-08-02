
using DlibDotNet;
using DlibDotNet.Extensions;
using System;
using System.Drawing;
using System.IO;
using System.Linq;

namespace FaceRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the face recognition model
            var faceRecognition = Dlib.GetFaceRecognition();
            
            // Load the pre-trained model for face detection
            var faceDetector = Dlib.GetFrontalFaceDetector();

            // Load the image containing the faces to be recognized
            var imagePath = "example.jpg";
            var image = Dlib.LoadImage<RgbPixel>(imagePath);

            // Detect faces in the image
            var faces = faceDetector.Operator(image);

            Console.WriteLine($"Found {faces.Length} faces");

            // Load the pre-trained model for face landmark detection
            var shapePredictor = Dlib.GetShapePredictor();

            foreach (var face in faces)
            {
                // Detect facial landmarks
                var shape = shapePredictor.Detect(image, face);
                
                // Recognize the face
                var faceDescriptor = faceRecognition.ComputeFaceDescriptor(image, shape);
                
                // Load the known face descriptors
                var knownFaceDescriptors = LoadKnownFaceDescriptors();

                // Compare the face descriptor with the known face descriptors
                var distances = knownFaceDescriptors.Select(knownFaceDesc =>
                    Dlib.GetEuclideanDistance(faceDescriptor, knownFaceDesc)
                ).ToArray();

                // Find the index of the closest matching face
                var closestIndex = Array.IndexOf(distances, distances.Min());

                Console.WriteLine($"Face matched with index {closestIndex}");
            }
        }

        private static Matrix<float>[] LoadKnownFaceDescriptors()
        {
            // Load the known face descriptors from a file
            var descriptorArray = File.ReadAllLines("known_faces.txt")
                .Select(line => line.Split(',').Select(float.Parse).ToArray())
                .Select(arr => DenseMatrix.OfArray(new[,] { { arr[0] }, { arr[1] }, { arr[2] } }))
                .ToArray();

            return descriptorArray;
        }
    }
}
