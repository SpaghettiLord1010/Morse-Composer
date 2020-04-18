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
            Alphabet.Add('A', ".-!");
            Alphabet.Add('B', "-...!");
            Alphabet.Add('C', "-.-.!");
            Alphabet.Add('D', "-..!");
            Alphabet.Add('E', ".!");
            Alphabet.Add('F', "..-.!");
            Alphabet.Add('G', "--.!");
            Alphabet.Add('H', "....!");
            Alphabet.Add('I', "..!");
            Alphabet.Add('J', ".---!");
            Alphabet.Add('K', "-.-!");
            Alphabet.Add('L', ".-..!");
            Alphabet.Add('M', "--!");
            Alphabet.Add('N', "-.!");
            Alphabet.Add('O', "---!");
            Alphabet.Add('P', ".--.!");
            Alphabet.Add('Q', "--.-!");
            Alphabet.Add('R', ".-.!");
            Alphabet.Add('S', "...!");
            Alphabet.Add('T', "-!");
            Alphabet.Add('U', "..-!");
            Alphabet.Add('V', "...-!");
            Alphabet.Add('W', ".--!");
            Alphabet.Add('X', "-..-!");
            Alphabet.Add('Y', "-.--!");
            Alphabet.Add('Z', "--..!");
            Alphabet.Add('0', "-----!");
            Alphabet.Add('1', ".----!");
            Alphabet.Add('2', "..---!");
            Alphabet.Add('3', "...--!");
            Alphabet.Add('4', "....-!");
            Alphabet.Add('5', ".....!");
            Alphabet.Add('6', "-....!");
            Alphabet.Add('7', "--...!");
            Alphabet.Add('8', "---..!");
            Alphabet.Add('9', "----.!");

            Alphabet.Add(' ', "_");

            Frequencies = new Dictionary<string, AudioValue>();
            Frequencies.Add("A1", new  AudioValue(21, 21));
            Frequencies.Add("A1#", new AudioValue(22, 22));
            Frequencies.Add("B1", new  AudioValue(23, 23));
            Frequencies.Add("C2", new  AudioValue(24, 24));
            Frequencies.Add("C2#", new AudioValue(25, 25));
            Frequencies.Add("D2", new  AudioValue(26, 26));
            Frequencies.Add("D2#", new AudioValue(27, 27));
            Frequencies.Add("E2", new  AudioValue(28, 28));
            Frequencies.Add("F2", new  AudioValue(29, 29));
            Frequencies.Add("F2#", new AudioValue(30, 30));
            Frequencies.Add("G2", new  AudioValue(31, 31));
            Frequencies.Add("G2#", new AudioValue(32, 32));
            Frequencies.Add("A2", new  AudioValue(33, 33));
            Frequencies.Add("A2#", new AudioValue(34, 34));
            Frequencies.Add("B2", new  AudioValue(35, 35));
            Frequencies.Add("C3", new  AudioValue(36, 36));
            Frequencies.Add("C3#", new AudioValue(37, 37));
            Frequencies.Add("D3", new  AudioValue(38, 38));
            Frequencies.Add("D3#", new AudioValue(39, 39));
            Frequencies.Add("E3", new  AudioValue(40, 40));
            Frequencies.Add("F3", new  AudioValue(41, 41));
            Frequencies.Add("F3#", new AudioValue(42, 42));
            Frequencies.Add("G3", new  AudioValue(43, 43));
            Frequencies.Add("G3#", new AudioValue(44, 44));
            Frequencies.Add("A3", new  AudioValue(45, 45));
            Frequencies.Add("A3#", new AudioValue(46, 46));
            Frequencies.Add("B3", new  AudioValue(47, 47));
            Frequencies.Add("C4", new  AudioValue(48, 48));
            Frequencies.Add("C4#", new AudioValue(49, 49));
            Frequencies.Add("D4", new  AudioValue(50, 50));
            Frequencies.Add("D4#", new AudioValue(51, 51));
            Frequencies.Add("E4", new  AudioValue(52, 52));
            Frequencies.Add("F4", new  AudioValue(53, 53));
            Frequencies.Add("F4#", new AudioValue(54, 54));
            Frequencies.Add("G4", new  AudioValue(55, 55));
            Frequencies.Add("G4#", new AudioValue(56, 56));
            Frequencies.Add("A4", new  AudioValue(57, 57));
            Frequencies.Add("A4#", new AudioValue(58, 58));
            Frequencies.Add("B4", new  AudioValue(59, 59));
            Frequencies.Add("C5", new  AudioValue(60, 60));
            Frequencies.Add("C5#", new AudioValue(61, 61));
            Frequencies.Add("D5", new  AudioValue(62, 62));
            Frequencies.Add("D5#", new AudioValue(63, 63));
            Frequencies.Add("E5", new  AudioValue(64, 64));
            Frequencies.Add("F5", new  AudioValue(65, 65));
            Frequencies.Add("F5#", new AudioValue(66, 66));
            Frequencies.Add("G5", new  AudioValue(67, 67));
            Frequencies.Add("G5#", new AudioValue(68, 68));
            Frequencies.Add("A5", new  AudioValue(69, 69));
            Frequencies.Add("A5#", new AudioValue(70, 70));
            Frequencies.Add("B5", new  AudioValue(71, 71));
            Frequencies.Add("C6", new  AudioValue(72, 72));
            Frequencies.Add("C6#", new AudioValue(73, 73));
            Frequencies.Add("D6", new  AudioValue(74, 74));
            Frequencies.Add("D6#", new AudioValue(75, 75));
            Frequencies.Add("E6", new  AudioValue(76, 76));
            Frequencies.Add("F6", new  AudioValue(77, 77));
            Frequencies.Add("F6#", new AudioValue(78, 78));
            Frequencies.Add("G6", new  AudioValue(79, 79));
            Frequencies.Add("G6#", new AudioValue(80, 80));
            Frequencies.Add("A6", new  AudioValue(81, 81));
            Frequencies.Add("A6#", new AudioValue(82, 82));
            Frequencies.Add("B6", new  AudioValue(83, 83));
            Frequencies.Add("C7", new  AudioValue(84, 84));
            Frequencies.Add("C7#", new AudioValue(85, 85));
            Frequencies.Add("D7", new  AudioValue(86, 86));
            Frequencies.Add("D7#", new AudioValue(87, 87));
            Frequencies.Add("E7", new  AudioValue(88, 88));
            Frequencies.Add("F7", new  AudioValue(89, 89));
            Frequencies.Add("F7#", new AudioValue(90, 90));
            Frequencies.Add("G7", new  AudioValue(91, 91));
            Frequencies.Add("G7#", new AudioValue(92, 92));
            Frequencies.Add("A7", new  AudioValue(93, 93));
            Frequencies.Add("A7#", new AudioValue(94, 94));
            Frequencies.Add("B7", new  AudioValue(95, 95));
            Frequencies.Add("C8", new  AudioValue(96, 96));
            Frequencies.Add("C8#", new AudioValue(97, 97));
            Frequencies.Add("D8", new  AudioValue(98, 98));
            Frequencies.Add("D8#", new AudioValue(99, 99));
            Frequencies.Add("E8", new  AudioValue(100, 100));
            Frequencies.Add("F8", new  AudioValue(101, 101));
            Frequencies.Add("F8#", new AudioValue(102, 102));
            Frequencies.Add("G8", new  AudioValue(103, 103));
            Frequencies.Add("G8#", new AudioValue(104, 104));
            Frequencies.Add("A8", new  AudioValue(105, 105));
            Frequencies.Add("A8#", new AudioValue(106, 106));
            Frequencies.Add("B8", new  AudioValue(107, 107));
            Frequencies.Add("C9", new  AudioValue(108, 108));
        }


    }
}
