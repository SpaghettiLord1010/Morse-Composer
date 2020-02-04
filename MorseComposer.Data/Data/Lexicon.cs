﻿using System.Collections.Generic;

namespace MorseComposer.Data
{
	public static class Lexicon
    {
        public static Dictionary<char, string> Alphabet { get; private set; }
        public static Dictionary<string, int> Frequencies { get; private set; }

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
            Frequencies.Add("C8#", 4435);
            Frequencies.Add("D8", 4699);
            Frequencies.Add("D8#", 4978);
            Frequencies.Add("E8", 5274);
            Frequencies.Add("F8", 5588);
            Frequencies.Add("F8#", 5920);
            Frequencies.Add("G8", 6272);
            Frequencies.Add("G8#", 6645);
            Frequencies.Add("A8", 7040);
            Frequencies.Add("A8#", 7459);
            Frequencies.Add("B8", 7902);
        }


    }
}
