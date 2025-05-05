
using System;
using Librosa;

namespace AudioPitchAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load audio file
            var audioPath = "path/to/audio/file.wav";
            var y = Librosa.Load(audioPath, 44100).Item1;

            // Compute pitch
            var pitches = Librosa.Piptrack(y);

            // Print pitch information
            Console.WriteLine("Pitch information:");
            for (int i = 0; i < pitches.GetLength(0); i++)
            {
                Console.WriteLine($"Frame {i}: {pitches[i]}");
            }
        }
    }
}
