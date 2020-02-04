using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace MorseComposer.Data
{












    public class DataContext
	{
        public string Message { get; private set; }
        public string Translated { get; private set; }

        private const string LetterSpace = "   ";
        private const string WordSpace = "       ";


        public bool Submit(string message)
        {
            Message = message;
            return true;
        }


        public bool Translate()
        {
            Translated = string.Empty;

            if (string.IsNullOrWhiteSpace(Message))
            {
                return false;
            }
            else
            {
                foreach (char character in Message)
                {
                    if (character == ' ')
                    {
                        Translated += WordSpace;
                    }
                    else
                    {
                        if (char.IsLetterOrDigit(character))
                        {
                            bool found = Lexicon.Alphabet.TryGetValue(character, out string letter);

                            if (found)
                            {
                                Translated += LetterSpace;
                                Translated += letter;
                            }
                            else
                            {
                                throw new Exception("The character \"" + character + "\" could not be found.");
                            }
                        }
                        else
                        {
                            Trace.WriteLine("The character \"" + character + "\" is not a letter.");
                        }
                    }
                }

                return true;
            }
        }



        public DataContext()
		{
            Message = string.Empty;
            Translated = string.Empty;


        }



	}



    public class MessageData
    {
        public List<SymbolData> Symbols { get; set; }

        public MessageData()
        {
            Symbols = new List<SymbolData>();
        }

    }


    public class SymbolData
    {
        public int Tone { get; set; }
        public double Delay { get; set; }

        public SymbolData()
        {
            Tone = 0;
            Delay = 1.0;
        }
    }





}
