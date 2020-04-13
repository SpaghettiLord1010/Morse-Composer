using System.Collections.Generic;

namespace MorseComposer.Data
{
    public static class Lexicon
    {
        public static Dictionary<char, string> Alphabet { get; private set; }
        public static Dictionary<string, AudioValue> Frequencies { get; private set; }

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

            Alphabet.Add(' ', " ");

            Frequencies = new Dictionary<string, AudioValue>();
            Frequencies.Add("D1", new AudioValue(37, 26));
            Frequencies.Add("D1#", new AudioValue(39, 27));
            Frequencies.Add("E1", new AudioValue(41, 28));
            Frequencies.Add("F1", new AudioValue(44, 29));
            Frequencies.Add("F1#", new AudioValue(46, 30));
            Frequencies.Add("G1", new AudioValue(49, 31));
            Frequencies.Add("G1#", new AudioValue(52, 32));
            Frequencies.Add("A1", new AudioValue(55, 33));
            Frequencies.Add("A1#", new AudioValue(58, 34));
            Frequencies.Add("B1", new AudioValue(62, 35));
            Frequencies.Add("C2", new AudioValue(65, 36));
            Frequencies.Add("C2#", new AudioValue(69, 37));
            Frequencies.Add("D2", new AudioValue(73, 38));
            Frequencies.Add("D2#", new AudioValue(78, 39));
            Frequencies.Add("E2", new AudioValue(82, 40));
            Frequencies.Add("F2", new AudioValue(87, 41));
            Frequencies.Add("F2#", new AudioValue(93, 42));
            Frequencies.Add("G2", new AudioValue(98, 43));
            Frequencies.Add("G2#", new AudioValue(104, 44));
            Frequencies.Add("A2", new AudioValue(110, 45));
            Frequencies.Add("A2#", new AudioValue(117, 46));
            Frequencies.Add("B2", new AudioValue(124, 47));
            Frequencies.Add("C3", new AudioValue(131, 48));
            Frequencies.Add("C3#", new AudioValue(139, 49));
            Frequencies.Add("D3", new AudioValue(147, 50));
            Frequencies.Add("D3#", new AudioValue(156, 51));
            Frequencies.Add("E3", new AudioValue(165, 52));
            Frequencies.Add("F3", new AudioValue(175, 53));
            Frequencies.Add("F3#", new AudioValue(185, 54));
            Frequencies.Add("G3", new AudioValue(196, 55));
            Frequencies.Add("G3#", new AudioValue(208, 56));
            Frequencies.Add("A3", new AudioValue(220, 57));
            Frequencies.Add("A3#", new AudioValue(233, 58));
            Frequencies.Add("B3", new AudioValue(247, 59));
            Frequencies.Add("C4", new AudioValue(262, 60));
            Frequencies.Add("C4#", new AudioValue(277, 61));
            Frequencies.Add("D4", new AudioValue(294, 62));
            Frequencies.Add("D4#", new AudioValue(311, 63));
            Frequencies.Add("E4", new AudioValue(330, 64));
            Frequencies.Add("F4", new AudioValue(349, 65));
            Frequencies.Add("F4#", new AudioValue(370, 66));
            Frequencies.Add("G4", new AudioValue(392, 67));
            Frequencies.Add("G4#", new AudioValue(415, 68));
            Frequencies.Add("A4", new AudioValue(440, 69));
            Frequencies.Add("A4#", new AudioValue(466, 70));
            Frequencies.Add("B4", new AudioValue(494, 71));
            Frequencies.Add("C5", new AudioValue(523, 72));
            Frequencies.Add("C5#", new AudioValue(554, 73));
            Frequencies.Add("D5", new AudioValue(587, 74));
            Frequencies.Add("D5#", new AudioValue(622, 75));
            Frequencies.Add("E5", new AudioValue(659, 76));
            Frequencies.Add("F5", new AudioValue(699, 77));
            Frequencies.Add("F5#", new AudioValue(740, 78));
            Frequencies.Add("G5", new AudioValue(784, 79));
            Frequencies.Add("G5#", new AudioValue(831, 80));
            Frequencies.Add("A5", new AudioValue(880, 81));
            Frequencies.Add("A5#", new AudioValue(932, 82));
            Frequencies.Add("B5", new AudioValue(988, 83));
            Frequencies.Add("C6", new AudioValue(1047, 84));
            Frequencies.Add("C6#", new AudioValue(1109, 85));
            Frequencies.Add("D6", new AudioValue(1175, 86));
            Frequencies.Add("D6#", new AudioValue(1245, 87));
            Frequencies.Add("E6", new AudioValue(1319, 88));
            Frequencies.Add("F6", new AudioValue(1397, 89));
            Frequencies.Add("F6#", new AudioValue(1480, 90));
            Frequencies.Add("G6", new AudioValue(1568, 91));
            Frequencies.Add("G6#", new AudioValue(1661, 92));
            Frequencies.Add("A6", new AudioValue(1760, 93));
            Frequencies.Add("A6#", new AudioValue(1865, 94));
            Frequencies.Add("B6", new AudioValue(1976, 95));
            Frequencies.Add("C7", new AudioValue(2093, 96));
            Frequencies.Add("C7#", new AudioValue(2217, 97));
            Frequencies.Add("D7", new AudioValue(2349, 98));
            Frequencies.Add("D7#", new AudioValue(2489, 99));
            Frequencies.Add("E7", new AudioValue(2637, 100));
            Frequencies.Add("F7", new AudioValue(2794, 101));
            Frequencies.Add("F7#", new AudioValue(2960, 102));
            Frequencies.Add("G7", new AudioValue(3136, 103));
            Frequencies.Add("G7#", new AudioValue(3322, 104));
            Frequencies.Add("A7", new AudioValue(3520, 105));
            Frequencies.Add("A7#", new AudioValue(3729, 106));
            Frequencies.Add("B7", new AudioValue(3951, 107));
            Frequencies.Add("C8", new AudioValue(4186, 108));
        }


    }
}
