using System.Collections.Generic;

namespace MorseComposer.Data
{
	public static class Lexicon
    {
        public static Dictionary<char, string> Alphabet { get; private set; }
        public static Dictionary<string, int> Frequencies { get; private set; }
        public static Dictionary<string, int> MIDIFrequencies { get; private set; }

        /// <summary>
        /// The space between each letter.
        /// </summary>
        public const string LetterSpace = "   ";

        /// <summary>
        /// The space between each word.
        /// </summary>
        public const string WordSpace = "       ";


        static Lexicon()
        {
            Alphabet = new Dictionary<char, string>();
            Alphabet.Add('A', ".-");
            Alphabet.Add('B', "-...");
            Alphabet.Add('C', "-.-.");
            Alphabet.Add('D', "-..");
            Alphabet.Add('E', ".");
            Alphabet.Add('F', "..-.");
            Alphabet.Add('G', "--.");
            Alphabet.Add('H', "....");
            Alphabet.Add('I', "..");
            Alphabet.Add('J', ".---");
            Alphabet.Add('K', "-.-");
            Alphabet.Add('L', ".-..");
            Alphabet.Add('M', "--");
            Alphabet.Add('N', "-.");
            Alphabet.Add('O', "---");
            Alphabet.Add('P', ".--.");
            Alphabet.Add('Q', "--.-");
            Alphabet.Add('R', ".-.");
            Alphabet.Add('S', "...");
            Alphabet.Add('T', "-");
            Alphabet.Add('U', "..-");
            Alphabet.Add('V', "...-");
            Alphabet.Add('W', ".--");
            Alphabet.Add('X', "-..-");
            Alphabet.Add('Y', "-.--");
            Alphabet.Add('Z', "--..");
            Alphabet.Add('0', "-----");
            Alphabet.Add('1', ".----");
            Alphabet.Add('2', "..---");
            Alphabet.Add('3', "...--");
            Alphabet.Add('4', "....-");
            Alphabet.Add('5', ".....");
            Alphabet.Add('6', "-....");
            Alphabet.Add('7', "--...");
            Alphabet.Add('8', "---..");
            Alphabet.Add('9', "----.");

            Frequencies = new Dictionary<string, int>();
            Frequencies.Add("D1", 37);
            Frequencies.Add("D1#", 39);
            Frequencies.Add("E1", 41);
            Frequencies.Add("F1", 44);
            Frequencies.Add("F1#", 46);
            Frequencies.Add("G1", 49);
            Frequencies.Add("G1#", 52);
            Frequencies.Add("A1", 55);
            Frequencies.Add("A1#", 58);
            Frequencies.Add("B1", 62);
            Frequencies.Add("C2", 65);
            Frequencies.Add("C2#", 69);
            Frequencies.Add("D2", 73);
            Frequencies.Add("D2#", 78);
            Frequencies.Add("E2", 82);
            Frequencies.Add("F2", 87);
            Frequencies.Add("F2#", 93);
            Frequencies.Add("G2", 98);
            Frequencies.Add("G2#", 104);
            Frequencies.Add("A2", 110);
            Frequencies.Add("A2#", 117);
            Frequencies.Add("B2", 124);
            Frequencies.Add("C3", 131);
            Frequencies.Add("C3#", 139);
            Frequencies.Add("D3", 147);
            Frequencies.Add("D3#", 156);
            Frequencies.Add("E3", 165);
            Frequencies.Add("F3", 175);
            Frequencies.Add("F3#", 185);
            Frequencies.Add("G3", 196);
            Frequencies.Add("G3#", 208);
            Frequencies.Add("A3", 220);
            Frequencies.Add("A3#", 233);
            Frequencies.Add("B3", 247);
            Frequencies.Add("C4", 262);
            Frequencies.Add("C4#", 277);
            Frequencies.Add("D4", 294);
            Frequencies.Add("D4#", 311);
            Frequencies.Add("E4", 330);
            Frequencies.Add("F4", 349);
            Frequencies.Add("F4#", 370);
            Frequencies.Add("G4", 392);
            Frequencies.Add("G4#", 415);
            Frequencies.Add("A4", 440);
            Frequencies.Add("A4#", 466);
            Frequencies.Add("B4", 494);
            Frequencies.Add("C5", 523);
            Frequencies.Add("C5#", 554);
            Frequencies.Add("D5", 587);
            Frequencies.Add("D5#", 622);
            Frequencies.Add("E5", 659);
            Frequencies.Add("F5", 699);
            Frequencies.Add("F5#", 740);
            Frequencies.Add("G5", 784);
            Frequencies.Add("G5#", 831);
            Frequencies.Add("A5", 880);
            Frequencies.Add("A5#", 932);
            Frequencies.Add("B5", 988);
            Frequencies.Add("C6", 1047);
            Frequencies.Add("C6#", 1109);
            Frequencies.Add("D6", 1175);
            Frequencies.Add("D6#", 1245);
            Frequencies.Add("E6", 1319);
            Frequencies.Add("F6", 1397);
            Frequencies.Add("F6#", 1480);
            Frequencies.Add("G6", 1568);
            Frequencies.Add("G6#", 1661);
            Frequencies.Add("A6", 1760);
            Frequencies.Add("A6#", 1865);
            Frequencies.Add("B6", 1976);
            Frequencies.Add("C7", 2093);
            Frequencies.Add("C7#", 2217);
            Frequencies.Add("D7", 2349);
            Frequencies.Add("D7#", 2489);
            Frequencies.Add("E7", 2637);
            Frequencies.Add("F7", 2794);
            Frequencies.Add("F7#", 2960);
            Frequencies.Add("G7", 3136);
            Frequencies.Add("G7#", 3322);
            Frequencies.Add("A7", 3520);
            Frequencies.Add("A7#", 3729);
            Frequencies.Add("B7", 3951);
            Frequencies.Add("C8", 4186);



            MIDIFrequencies = new Dictionary<string, int>();
            MIDIFrequencies.Add("D1", 26);
            MIDIFrequencies.Add("D1#", 27);
            MIDIFrequencies.Add("E1", 28);
            MIDIFrequencies.Add("F1", 29);
            MIDIFrequencies.Add("F1#", 30);
            MIDIFrequencies.Add("G1", 31);
            MIDIFrequencies.Add("G1#", 32);
            MIDIFrequencies.Add("A1", 33);
            MIDIFrequencies.Add("A1#", 34);
            MIDIFrequencies.Add("B1", 35);
            MIDIFrequencies.Add("C2", 36);
            MIDIFrequencies.Add("C2#", 37);
            MIDIFrequencies.Add("D2", 38);
            MIDIFrequencies.Add("D2#", 39);
            MIDIFrequencies.Add("E2", 40);
            MIDIFrequencies.Add("F2", 41);
            MIDIFrequencies.Add("F2#", 42);
            MIDIFrequencies.Add("G2", 43);
            MIDIFrequencies.Add("G2#", 44);
            MIDIFrequencies.Add("A2", 45);
            MIDIFrequencies.Add("A2#", 46);
            MIDIFrequencies.Add("B2", 47);
            MIDIFrequencies.Add("C3", 48);
            MIDIFrequencies.Add("C3#", 49);
            MIDIFrequencies.Add("D3", 50);
            MIDIFrequencies.Add("D3#", 51);
            MIDIFrequencies.Add("E3", 52);
            MIDIFrequencies.Add("F3", 53);
            MIDIFrequencies.Add("F3#", 54);
            MIDIFrequencies.Add("G3", 55);
            MIDIFrequencies.Add("G3#", 56);
            MIDIFrequencies.Add("A3", 57);
            MIDIFrequencies.Add("A3#", 58);
            MIDIFrequencies.Add("B3", 59);
            MIDIFrequencies.Add("C4", 60);
            MIDIFrequencies.Add("C4#", 61);
            MIDIFrequencies.Add("D4", 62);
            MIDIFrequencies.Add("D4#", 63);
            MIDIFrequencies.Add("E4", 64);
            MIDIFrequencies.Add("F4", 65);
            MIDIFrequencies.Add("F4#", 66);
            MIDIFrequencies.Add("G4", 67);
            MIDIFrequencies.Add("G4#", 68);
            MIDIFrequencies.Add("A4", 69);
            MIDIFrequencies.Add("A4#", 70);
            MIDIFrequencies.Add("B4", 71);
            MIDIFrequencies.Add("C5", 72);
            MIDIFrequencies.Add("C5#", 73);
            MIDIFrequencies.Add("D5", 74);
            MIDIFrequencies.Add("D5#", 75);
            MIDIFrequencies.Add("E5", 76);
            MIDIFrequencies.Add("F5", 77);
            MIDIFrequencies.Add("F5#", 78);
            MIDIFrequencies.Add("G5", 79);
            MIDIFrequencies.Add("G5#", 80);
            MIDIFrequencies.Add("A5", 81);
            MIDIFrequencies.Add("A5#", 82);
            MIDIFrequencies.Add("B5", 83);
            MIDIFrequencies.Add("C6", 84);
            MIDIFrequencies.Add("C6#", 85);
            MIDIFrequencies.Add("D6", 86);
            MIDIFrequencies.Add("D6#", 87);
            MIDIFrequencies.Add("E6", 88);
            MIDIFrequencies.Add("F6", 89);
            MIDIFrequencies.Add("F6#", 90);
            MIDIFrequencies.Add("G6", 91);
            MIDIFrequencies.Add("G6#", 92);
            MIDIFrequencies.Add("A6", 93);
            MIDIFrequencies.Add("A6#", 94);
            MIDIFrequencies.Add("B6", 95);
            MIDIFrequencies.Add("C7", 96);
            MIDIFrequencies.Add("C7#", 97);
            MIDIFrequencies.Add("D7", 98);
            MIDIFrequencies.Add("D7#", 99);
            MIDIFrequencies.Add("E7", 100);
            MIDIFrequencies.Add("F7", 101);
            MIDIFrequencies.Add("F7#", 102);
            MIDIFrequencies.Add("G7", 103);
            MIDIFrequencies.Add("G7#", 104);
            MIDIFrequencies.Add("A7", 105);
            MIDIFrequencies.Add("A7#", 106);
            MIDIFrequencies.Add("B7", 107);
            MIDIFrequencies.Add("C8", 108);
        }


    }
}
