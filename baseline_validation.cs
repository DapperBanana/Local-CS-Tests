
using Numpy;
using librosa;

class Program
{
    static void Main()
    {
        // Load audio file
        var y = np.load("audio_file.wav");

        // Calculate pitch using librosa library
        var pitches = librosa.feature.chroma_stft(y);

        // Print out the pitches
        Console.WriteLine("Pitches:");
        Console.WriteLine(pitches);

        // Find the most dominant pitch
        var dominantPitch = np.argmax(np.mean(pitches, axis: 1));

        // Print out the dominant pitch
        Console.WriteLine($"Dominant Pitch: {dominantPitch}");
    }
}
