using System;
using System.ComponentModel;
using System.Linq;

namespace MorseComposer.Data
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class SymbolData
	{
		/// <summary>
		/// The letter character for this symbol.
		/// </summary>
		/// <example>A, B, C, & D</example>
		public char Character { get; set; }

		/// <summary>
		/// The Morse code character for this symbol.
		/// </summary>
		/// <example>....</example>
		/// <example>----</example>
		public string Code { get; set; }

		/// <summary>
		/// The tone frequency for this symbol.
		/// </summary>
		public int[] Tone { get; set; }

		/// <summary>
		/// The tone delay for this symbol.
		/// </summary>
		public double[] Delay { get; set; }

		[Obsolete("use SymbolData(char character) instead")]
		public SymbolData() {
			//Character = Lexicon.Alphabet.Keys.ToArray()[0];
			//Code = string.Empty;
			//Tone = Lexicon.Frequencies.Values.ToArray()[0].Frequency;
			//Delay = 1.0;
		}

		public SymbolData(char character) {

			char uppercaseCharacter = character.ToString().ToUpper()[0];

			Character = character;
			Code = Lexicon.Alphabet[uppercaseCharacter];

			Tone = new int[Code.Length];
			for (int i = 0; i < Tone.Length; i++) {
				Tone[i] = Lexicon.Frequencies.Values.ToArray()[0].Frequency;
			}

			Delay = new double[Code.Length];
			for (int i = 0; i < Code.Length; i++) {
				Delay[i] = 1.0;
			}
		}


		public override string ToString()
		{
			return Character.ToString();
		}


	}
}
