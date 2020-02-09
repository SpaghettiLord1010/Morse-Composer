﻿using System.ComponentModel;
using System.Linq;

namespace MorseComposer.Data
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
    public class SymbolData
    {
        /// <summary>
        /// The letter character for this symbol.
        /// </summary>
        public char Character { get; set; }

        /// <summary>
        /// The Morse code character for this symbol.
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// The tone frequency for this symbol.
        /// </summary>
        public int Tone { get; set; }

        /// <summary>
        /// The tone delay for this symbol.
        /// </summary>
        public double Delay { get; set; }


        public SymbolData()
        {
            Character = Lexicon.Alphabet.Keys.ToArray()[0]; ;
            Code = string.Empty;
            Tone = Lexicon.Frequencies.Values.ToArray()[0];
            Delay = 1.0;
        }


        public override string ToString()
        {
            return Character.ToString();
        }


    }
}