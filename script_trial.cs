
using System;
using Librosa;

namespace PitchAnalysis
{
    class Program
    {
        static void Main(string[] args)
        {
            // Load audio file
            string audioPath = "path_to_audio_file.wav";
            float[] audioData = Librosa.Load(audioPath, out int sampleRate);

            // Compute the pitch
            float[] pitches = Librosa.Pitch.Piptrack(audioData, sampleRate);

            // Find the maximum pitch
            float maxPitch = 0;
            for (int i = 0; i < pitches.Length; i++)
            {
                if (pitches[i] > maxPitch)
                {
                    maxPitch = pitches[i];
                }
            }

            Console.WriteLine("The maximum pitch in the audio file is: " + maxPitch);
        }
    }
}
