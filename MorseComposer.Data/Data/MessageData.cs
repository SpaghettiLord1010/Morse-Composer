using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;

namespace MorseComposer.Data
{
	[TypeConverter(typeof(ExpandableObjectConverter))]
	public class MessageData
	{
		public string Text { get; private set; }
		public string Translated { get; private set; }

		public List<SymbolData> Symbols { get; private set; }


		public MessageData()
		{
			Text = string.Empty;
			Translated = string.Empty;
			Symbols = new List<SymbolData>();
		}


		public bool Submit(string text)
		{
			Text = text;
			Symbols.Clear();

			foreach (char character in text)
			{
				if (char.IsLetterOrDigit(character) || character == ' ')
				{
					SymbolData symbol = new SymbolData(character);
					Symbols.Add(symbol);
				}
				else
				{
					Trace.WriteLine("The character \"" + character + "\" is not a letter, skipping.");
				}
			}

			return Symbols.Count > 0;
		}


		public bool Translate()
		{
			Translated = string.Empty;

			if (string.IsNullOrWhiteSpace(Text))
			{
				Trace.WriteLine("There is no text to translate.");
				return false;
			}
			else if (Symbols.Count < 1)
			{
				Trace.WriteLine("There are no symbols to translate.");
				return false;
			}
			else
			{
				foreach (var symbol in Symbols)
				{
					if (symbol.Character == ' ')
					{
						Translated += Lexicon.WordSpace;
					}
					else
					{
						if (char.IsLetterOrDigit(symbol.Character))
						{
							bool found = Lexicon.Alphabet.TryGetValue(symbol.Character, out string code);

							if (found)
							{
								symbol.Code = code;


								if (!string.IsNullOrEmpty(Translated))
								{
									Translated += Lexicon.LetterSpace;
								}
								Translated += code;
							}
							else
							{
								throw new Exception("The character \"" + symbol.Character + "\" could not be found.");
							}
						}
						else
						{
							Trace.WriteLine("The character \"" + symbol.Character + "\" is not a letter.");
						}
					}
				}

				return true;
			}
		}


		// TODO: Needs to handle whitespace delays correctly.
		public bool Play()
		{
			if (Symbols.Count > 0)
			{
				const int duration = 500;
				foreach (var symbol in Symbols)
				{
					if (symbol.Character != ' ') {

						for (var i = 0; i < symbol.Code.Length; i++) {
							Console.Beep(symbol.Tone[i], duration);
							Thread.Sleep(Convert.ToInt32(symbol.Delay[i]));
							Trace.WriteLine(string.Format("BEEP! (Tone:{0}, Duration:{1}, Delay:{2})", symbol.Tone[i], duration, symbol.Delay[i]));
						}
					} else {
						Thread.Sleep(duration);
					}
				}
				return true;
			}
			else
			{
				Trace.WriteLine("There are no symbols to play tones.");
				return false;
			}
		}

		// TODO: With these new data requirements I need to rethink the `SymbolData` class.
		//       The below function at least creates a well formed file for conversion in the python script.
		// TODO: The tone variable is incorrect for MIDI, dont use frequency for the tone here.
		// TODO: The distinction between "time", "duration", and "delay" needs to be more clearly defined.
		public string[] GetLines()
		{
			List<string> lines = new List<string>();

			foreach (SymbolData symbol in Symbols)
			{
				foreach (char character in symbol.Code)
				{
					lines.Add(symbol.Tone.ToString());
					lines.Add(symbol.Delay.ToString());

					if (character == '.')
					{
						lines.Add("1");
					}
					else if (character == '-')
					{
						lines.Add("2");
					}
					else
					{ // Probably is a blank space
						lines.Add("0");
					}

					lines.Add(string.Empty);
				}
			}

			return lines.ToArray();
		}


	}
}
