using System;
using System.IO;
using NAudio.Wave;

class PitchDetection
{
    static void Main(string[] args)
    {
        string audioFilePath = "path_to_your_audio.wav";

        if (!File.Exists(audioFilePath))
        {
            Console.WriteLine("Audio file not found.");
            return;
        }

        // Load audio file
        using (var reader = new AudioFileReader(audioFilePath))
        {
            int sampleRate = reader.WaveFormat.SampleRate;
            int channels = reader.WaveFormat.Channels;

            // Read entire audio data into buffer
            var samples = new float[reader.Length / sizeof(float)];
            int samplesRead = reader.Read(samples, 0, samples.Length);

            // If stereo, convert to mono by averaging channels
            float[] monoSamples;
            if (channels == 2)
            {
                monoSamples = new float[samplesRead / 2];
                for (int i = 0, j = 0; i < samplesRead; i += 2, j++)
                {
                    monoSamples[j] = (samples[i] + samples[i + 1]) / 2;
                }
            }
            else
            {
                monoSamples = new float[samplesRead];
                Array.Copy(samples, monoSamples, samplesRead);
            }

            // Define segment length (e.g., 2048 samples) for pitch detection
            int segmentSize = 2048;
            double[] pitches = new double[monoSamples.Length / segmentSize];

            for (int i = 0; i < monoSamples.Length - segmentSize; i += segmentSize)
            {
                var segment = new float[segmentSize];
                Array.Copy(monoSamples, i, segment, 0, segmentSize);
                double pitch = DetectPitch(segment, sampleRate);
                pitches[i / segmentSize] = pitch;
                Console.WriteLine($"Segment {i / segmentSize}: Pitch = {pitch} Hz");
            }
        }
    }

    // A simple autocorrelation-based pitch detection
    static double DetectPitch(float[] segment, int sampleRate)
    {
        int size = segment.Length;
        double[] autocorrelation = new double[size];
        double maxCorr = 0;
        int maxLag = 0;

        // Compute autocorrelation
        for (int lag = 0; lag < size / 2; lag++)
        {
            double corr = 0;
            for (int i = 0; i < size - lag; i++)
            {
                corr += segment[i] * segment[i + lag];
            }
            autocorrelation[lag] = corr;

            // Find the lag with maximum autocorrelation (fundamental frequency)
            if (corr > maxCorr)
            {
                maxCorr = corr;
                maxLag = lag;
            }
        }

        if (maxLag == 0)
            return 0;

        // Convert lag to frequency
        double frequency = sampleRate / (double)maxLag;
        return frequency;
    }
}