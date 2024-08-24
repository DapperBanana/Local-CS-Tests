
using System;
using System.Numerics;
using Librosa;

class Program
{
    static void Main()
    {
        string audioFilePath = "path_to_audio_file.wav";
        
        // Load audio data
        float[] audioData = Librosa.Load(audioFilePath);
        
        // Use librosa to calculate the pitch
        float[] pitches = Librosa.Pitch.Piptrack(audioData);
        
        // Find the index of the maximum pitch value
        int maxPitchIndex = Utils.FindIndexOfMaxValue(pitches);
        
        // Calculate the pitch frequency from the index
        float pitchFrequency = Utils.IndexToFreq(maxPitchIndex, audioData.Length);
        
        Console.WriteLine($"The estimated pitch frequency is: {pitchFrequency} Hz");
    }
}

public static class Utils
{
    public static int FindIndexOfMaxValue(float[] array)
    {
        float maxValue = float.MinValue;
        int maxIndex = -1;

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > maxValue)
            {
                maxValue = array[i];
                maxIndex = i;
            }
        }

        return maxIndex;
    }

    public static float IndexToFreq(int index, int length)
    {
        return (float)index / length * Constants.SamplingRate / 2;
    }
}
