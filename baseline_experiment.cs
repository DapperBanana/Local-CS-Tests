
using DlibDotNet;
using DlibDotNet.Extensions;
using DlibDotNet.ImageTransforms;
using System;
using System.IO;

namespace FaceRecognitionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the pre-trained face recognition model
            using (var faceRecognition = Dlib.GetFaceRecognition())
            {
                // Load the image to be recognized
                var imagePath = "test.jpg";
                var image = Dlib.LoadImage<RgbPixel>(imagePath);

                // Detect faces in the image
                var faces = Dlib.GetFrontalFaceDetector().Operator(image);

                foreach (var face in faces)
                {
                    var faceDescriptor = faceRecognition.ComputeFaceDescriptor(image, face);

                    Console.WriteLine("Face Descriptor:");
                    foreach (var descriptor in faceDescriptor)
                    {
                        Console.Write(descriptor + " ");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
