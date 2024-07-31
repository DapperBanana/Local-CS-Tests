
using NAudio.Wave;
using System;
using System.Numerics;

class Program
{
    static void Main()
    {
        string audioFilePath = "path/to/audio/file.wav";

        using (var audioFile = new AudioFileReader(audioFilePath))
        {
            var pitch = DetectPitch(audioFile);

            Console.WriteLine($"The pitch of the audio file is: {pitch} Hz");
        }
    }

    static float DetectPitch(AudioFileReader audioFile)
    {
        int bufferSize = 1024;
        int sampleRate = audioFile.WaveFormat.SampleRate;

        Complex[] fftData = new Complex[bufferSize];
        float[] audioData = new float[bufferSize];

        int bytesRead;
        float pitch = 0;

        do
        {
            bytesRead = audioFile.Read(audioData, 0, bufferSize);

            if (bytesRead > 0)
            {
                for (int i = 0; i < bufferSize; i++)
                {
                    fftData[i] = new Complex(audioData[i], 0);
                }

                FourierTransform.FFT(fftData, FourierTransform.Direction.Forward);

                int maxIndex = 0;
                float maxValue = 0;

                for (int i = 0; i < bufferSize / 2; i++)
                {
                    var magnitude = fftData[i].Magnitude;

                    if (magnitude > maxValue)
                    {
                        maxValue = magnitude;
                        maxIndex = i;
                    }
                }

                pitch = maxIndex * sampleRate / bufferSize;
            }
        } while (bytesRead > 0);

        return pitch;
    }
}
