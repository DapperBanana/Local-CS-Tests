
using NAudio.Wave;
using NAudio.Dsp;

class PitchAnalyzer
{
    public static float AnalyzePitch(byte[] audioData)
    {
        var signal = new float[audioData.Length / 2];
        for (int i = 0; i < signal.Length; i++)
        {
            short sample = BitConverter.ToInt16(audioData, i * 2);
            signal[i] = sample / 32768f; // Normalize to range [-1, 1]
        }

        var fft = new FastFourierTransform();
        var pitchIndex = fft.DetectPitchIndex(signal);

        float pitchHz = (44100 / 2) * pitchIndex / signal.Length;
        return pitchHz;
    }
}

class FastFourierTransform
{
    public int DetectPitchIndex(float[] signal)
    {
        var fft = new Complex[signal.Length];
        for (int i = 0; i < signal.Length; i++)
        {
            fft[i].X = signal[i];
        }

        FourierTransform.FFT(fft, FourierTransform.Direction.Forward);

        int maxIndex = 0;
        float maxValue = 0;
        for (int i = 0; i < signal.Length / 2; i++)
        {
            float magnitude = fft[i].Magnitude;
            if (magnitude > maxValue)
            {
                maxIndex = i;
                maxValue = magnitude;
            }
        }

        return maxIndex;
    }
}
