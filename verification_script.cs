
using System;
using LibFftw3;
using LibrosaSharp;

namespace AudioPitchAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            string audioFilePath = "path_to_audio_file.wav";

            // Load audio data
            float[] audioData = Librosa.Load(audioFilePath, out int sampleRate);

            // Compute pitch using librosa
            float[] pitches = Librosa.Piptrack(audioData, sampleRate);

            // Analyze pitch data
            foreach (float pitch in pitches)
            {
                Console.WriteLine($"Pitch: {pitch}");
            }
        }
    }
}
