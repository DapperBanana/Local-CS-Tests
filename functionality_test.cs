
using Librosa;

class Program
{
    static void Main()
    {
        // Load audio file
        string audioFilePath = "example_audio.wav";
        float[] audioData = AudioUtilities.Load(audioFilePath);

        // Get pitch using librosa library
        float[] pitches = Pitch.Piptrack(audioData);

        // Print out pitch values
        foreach(float pitch in pitches)
        {
            Console.WriteLine("Pitch: " + pitch);
        }
    }
}
