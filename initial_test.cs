
using NAudio.Wave;
using NAudio.Dsp;

public class PitchAnalyzer
{
    private WaveFileReader waveFileReader;
    private int sampleRate;
    
    public PitchAnalyzer(string audioFilePath)
    {
        waveFileReader = new WaveFileReader(audioFilePath);
        sampleRate = waveFileReader.WaveFormat.SampleRate;
    }
    
    public double AnalyzePitch()
    {
        const int windowSize = 1024;
        float[] buffer = new float[windowSize];
        Complex[] fftBuffer = new Complex[windowSize];
        
        WaveBuffer waveBuffer = new WaveBuffer(buffer);
        
        int bytesRead;
        double maxFrequency = 0;
        
        while ((bytesRead = waveFileReader.Read(buffer, 0, windowSize)) > 0)
        {
            for (int i = 0; i < windowSize; i++)
            {
                fftBuffer[i].X = buffer[i] * (float)FastFourierTransform.HammingWindow(i, windowSize);
                fftBuffer[i].Y = 0;
            }
            
            FastFourierTransform.FFT(true, (int)Math.Log(windowSize, 2.0), fftBuffer);
            
            double[] frequencies = new double[windowSize / 2];
            
            for (int i = 0; i < windowSize / 2; i++)
            {
                frequencies[i] = (double)(i * sampleRate) / windowSize;
            }
            
            int maxIndex = 0;
            double maxValue = 0;
            
            for (int i = 0; i < windowSize / 2; i++)
            {
                if (fftBuffer[i].Magnitude > maxValue)
                {
                    maxValue = fftBuffer[i].Magnitude;
                    maxIndex = i;
                }
            }
            
            double frequency = frequencies[maxIndex];
            
            if (frequency > maxFrequency)
            {
                maxFrequency = frequency;
            }
        }
        
        return maxFrequency;
    }
}
