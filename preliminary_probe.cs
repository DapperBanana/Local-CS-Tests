
using Python.Runtime;

class Program
{
    static void Main(string[] args)
    {
        using (Py.GIL())
        {
            dynamic librosa = Py.Import("librosa");

            // Load audio file
            string audioFile = "path/to/audio/file.mp3";
            dynamic y = librosa.core.load(audioFile);

            // Extract pitch from audio data
            dynamic y_harmonic, y_percussive;
            librosa.decompose.hpss(y, out y_harmonic, out y_percussive);

            dynamic pitches, magnitudes;
            librosa.core.piptrack(y=y_harmonic, sr=librosa.core.get_samplerate(audioFile), fmin=librosa.core.note_to_hz("C1"), fmax=librosa.core.note_to_hz("C6"), threshold=0.75);

            // Print pitch values
            for (int i = 0; i < pitches.size; i++)
            {
                Console.WriteLine($"Frame {i}: {pitches[0, i]} Hz");
            }
        }
    }
}
