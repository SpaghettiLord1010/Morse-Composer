namespace MorseComposer.Data
{
	public struct AudioValue
    {
        public readonly int Frequency;
        public readonly int MIDI;

        public AudioValue(int frequency, int midi)
        {
            Frequency = frequency;
            MIDI = midi;
        }
    }
}
