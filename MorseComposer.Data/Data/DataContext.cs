using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using System.Runtime;


namespace MorseComposer.Data
{
    public class DataContext
	{
        public MessageData Message { get; private set; }


        public DataContext()
        {
            Message = new MessageData();
        }


        public void Output()
        {
            bool firstRun = true;
            int tone = 0;
            int time = 0;
            int duration = 0;
            string inputText = "";

            foreach (var symbol in Message.Symbols)
            {
                for(int morseID = 0; morseID < symbol.Code.Length; morseID++)
                {
                    var morseChar = symbol.Code[morseID];
                    var morseTone = symbol.Tone[morseID];
                    var morseDelay = symbol.Delay[morseID];
                    if (!firstRun)
                    {
                        if (morseChar == '.')
                        {
                            duration = 1;
                            time = time + (int)morseDelay;
                            
                        }
                        else if(morseChar == '-')
                        {
                            duration = 2;
                            time = time + (int)morseDelay;

                        }
                        else if(morseChar == ' ')
                        {
                            time = time + (int)morseDelay;
                        }

                    }
                    else
                    {
                        time = 0;
                        firstRun = false;
                        if (morseChar == '.')
                        {
                            duration = 1;
                            time = time + (int)morseDelay;

                        }
                        else if (morseChar == '-')
                        {
                            duration = 2;
                            time = time + (int)morseDelay;

                        }
                        else if (morseChar == ' ')
                        {
                            time = time + (int)morseDelay;
                        }
                    }
                }
                inputText = inputText + symbol.Tone + Environment.NewLine + time + Environment.NewLine + duration + Environment.NewLine + Environment.NewLine;
            }

			string input = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MorseComposer", "temp.txt");

            // TODO: Finish up the input file writer.
            Directory.GetParent(input).Create();

            File.WriteAllText(input, inputText);
            MessageBox.Show("Hi, input is: " + input + Environment.NewLine + "Lines is: ");
            MessageBox.Show(inputText);

			if (File.Exists(input))
			{
				Python.PIP("install", "midiutil");
				if (Python.Execute("TextToMid.py", null))
				{
					string output = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MorseComposer", "MorseComposerOutput.mid");
					if (File.Exists(output))
					{
						Console.WriteLine(string.Format("Created {0} successfully.", output));
						FileInfo file = new FileInfo(output);
						Process.Start(file.Directory.FullName); // open the directory
					}
					else
					{
						Console.WriteLine(string.Format("An output file could not be created at {0}", output));
					}
				}
				else
				{
					Console.WriteLine(string.Format("The python script 'TextToMid.py' has failed.", input));
				}
			}
			else
			{
				Console.WriteLine(string.Format("The file {0} must exist.", input));
			}
		}


    }
}
