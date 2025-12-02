using System;
using System.IO;
using NAudio.Wave;

class PitchDetection
{
    static void Main(string[] args)
    {
        string audioFilePath = "your_audio_file.wav"; // Replace with your audio file path

        if (!File.Exists(audioFilePath))
        {
            Console.WriteLine("Audio file not found.");
            return;
        }

        using (var reader = new AudioFileReader(audioFilePath))
        {
            int sampleRate = reader.WaveFormat.SampleRate;
            int channels = reader.WaveFormat.Channels;

            // Read entire audio data into buffer
            int sampleCount = (int)(reader.Length / (reader.WaveFormat.BitsPerSample / 8));
            float[] samples = new float[sampleCount];
            int samplesRead = reader.Read(samples, 0, sampleCount);

            // If stereo, convert to mono by averaging channels
            if (channels > 1)
            {
                float[] monoSamples = new float[samplesRead / channels];
                for (int i = 0; i < monoSamples.Length; i++)
                {
                    float sum = 0;
                    for (int ch = 0; ch < channels; ch++)
                    {
                        sum += samples[i * channels + ch];
                    }
                    monoSamples[i] = sum / channels;
                }
                samples = monoSamples;
                samplesRead = monoSamples.Length;
            }

            // Perform pitch detection on a segment (e.g., first 1 second)
            int segmentLength = sampleRate; // 1 second segment
            float[] segment = new float[segmentLength];
            Array.Copy(samples, 0, segment, 0, segmentLength);

            double pitch = AutoCorrelationPitch(segment, sampleRate);
            Console.WriteLine($"Estimated pitch: {pitch} Hz");
        }
    }

    static double AutoCorrelationPitch(float[] buffer, int sampleRate)
    {
        int size = buffer.Length;
        double[] autocorrelation = new double[size];

        // Compute autocorrelation
        for (int lag = 0; lag < size; lag++)
        {
            double sum = 0;
            for (int i = 0; i < size - lag; i++)
            {
                sum += buffer[i] * buffer[i + lag];
            }
            autocorrelation[lag] = sum;
        }

        // Find the peak in autocorrelation after the first minimum
        int peakIndex = 0;
        double maxVal = double.MinValue;
        for (int i = 1; i < autocorrelation.Length; i++)
        {
            if (autocorrelation[i] > maxVal)
            {
                maxVal = autocorrelation[i];
                peakIndex = i;
            }
        }

        // Calculate pitch
        if (peakIndex == 0)
            return 0; // No pitch detected

        double fundamentalFreq = sampleRate / (double)peakIndex;
        return fundamentalFreq;
    }
}