
using System;
using DlibDotNet;
using DlibDotNet.Extensions;
using DlibDotNet.Dnn;

namespace FaceRecognition
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load the face recognition model
            var net = Dlib.LoadFaceRecognitionModel(@"dlib_face_recognition_resnet_model_v1.dat");

            // Load the facial landmark model
            var sp = ShapePredictor.Deserialize(@"shape_predictor_68_face_landmarks.dat");

            // Load an image to recognize faces in
            var img = Dlib.LoadImageAsMatrix<RgbPixel>(@"image.jpg");

            // Detect faces in the image
            var dets = Dlib.GetFrontalFaceDetector().Operator(img);

            foreach (var d in dets)
            {
                // Get the facial landmarks for each face
                var shape = sp.Detect(img, d);

                // Recognize the face
                var faceDescriptor = net.ComputeFaceDescriptor(img, shape);

                // Print the face descriptor
                Console.WriteLine($"Face Descriptor: {faceDescriptor}");
            }
        }
    }
}
