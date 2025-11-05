
using System;
using librosa; // Import the librosa library

class Program
{
    static void Main()
    {
        // Load audio file
        string audioFile = "example_audio.wav";
        float[] audioData = librosa.core.load(audioFile, sr: 22050, mono: true);

        // Get pitch using librosa
        float[] pitchData = librosa.core.piptrack(y: audioData, sr: 22050);

        // Find the dominant pitch
        float dominantPitch = FindDominantPitch(pitchData);

        Console.WriteLine($"Dominant pitch: {dominantPitch} Hz");
    }

    static float FindDominantPitch(float[] pitchData)
    {
        float[] meanPitch = librosa.core.mean(pitchData, axis: 0);
        int maxIndex = 0;
        float maxVal = 0;

        for (int i = 0; i < meanPitch.Length; i++)
        {
            if (meanPitch[i] > maxVal)
            {
                maxIndex = i;
                maxVal = meanPitch[i];
            }
        }

        return maxIndex;
    }
}
