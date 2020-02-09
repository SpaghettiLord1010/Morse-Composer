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
					SymbolData symbol = new SymbolData();
					symbol.Character = character;
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
					Console.Beep(symbol.Tone, duration);
					Thread.Sleep(Convert.ToInt32(symbol.Delay));
					Trace.WriteLine(string.Format("BEEP! (Tone:{0}, Duration:{1}, Delay:{2})", symbol.Tone, duration, symbol.Delay));
				}
				return true;
			}
			else
			{
				Trace.WriteLine("There are no symbols to play tones.");
				return false;
			}
		}


		// TODO: The `SymbolData.Character` is NOT a dot or dash. Its the alphabetical letter.
		// The comparison below is incorrect.
		public string GetCharText()
		{
			const int time = 0; // TODO: This is an unused variable!
			int duration = 0;
			string text = string.Empty;

			foreach (var symbol in Symbols)
			{
				// setting the length
				if (symbol.Character == '.')
				{
					duration = 1;
				}
				else if (symbol.Character == '-')
				{
					duration = 2;
				}
				else
				{
					// unhandled code branch
				}
				// setting the frequency
				text += Environment.NewLine + symbol.Tone + Environment.NewLine + time + Environment.NewLine + duration;
			}
			return text;
		}


	}
}
