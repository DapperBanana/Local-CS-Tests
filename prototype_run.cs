
using System;
using DlibDotNet;
using DlibDotNet.Extensions;
using DlibDotNet.ImageTransforms;
using DlibDotNet.Extensions.Array2D;
using Dlib_Net;

namespace FaceRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the face recognition model
            var faceRecognition = Dlib.GetFaceRecognition();

            // Load the image containing the face to recognize
            var img = Dlib.LoadImage<RgbPixel>("path_to_image.jpg");

            // Detect faces in the image
            var faces = Dlib.GetFaceDetector().Operator(img);

            if (faces.Length > 0)
            {
                // Get the face descriptor for the first detected face
                var faceDescriptor = faceRecognition.ComputeFaceDescriptor(img, faces[0]);

                // Load the precomputed face descriptors
                var savedDescriptors = Dlib.GetFaceDescriptors();

                // Compare the face descriptor with the saved ones
                foreach (var savedDescriptor in savedDescriptors)
                {
                    var distance = Dlib.Length(faceDescriptor - savedDescriptor);
                    Console.WriteLine($"Distance: {distance}");
                }
            }
            else
            {
                Console.WriteLine("No face detected in the image.");
            }
        }
    }
}
