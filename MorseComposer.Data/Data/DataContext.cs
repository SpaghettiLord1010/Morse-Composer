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
			string input = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MorseComposer", "temp.txt");

            // TODO: Finish up the input file writer.
            string[] lines = Message.GetLines();

            bool firstRun = true;
            int tone = 0;
            int time = 0;
            int duration = 0;
            string inputText = "";

            foreach(char line in Message.Translated.Replace("   ", " "))
            {
                //MessageBox.Show(line.ToString()); -Spaghtti - Was for debugging
                if(line.ToString() == ".")
                {
                    duration = 1;
                    if (firstRun)
                    {
                        time = 0;
                        firstRun = false;
                    }
                    else
                    {
                        //just in the meanwhile - get delay from MorseSymbolEntry Delay NumUpDown instead of 1 - Spaghetti
                        time = time + 1;
                    }
                }
                else if(line.ToString() == "-")
                {
                    duration = 2;
                    if (firstRun)
                    {
                        time = 0;
                        firstRun = false;
                    }
                    else
                    {
                        //just in the meanwhile - get delay from MorseSymbolEntry Delay NumUpDown instead of 1 - Spaghetti
                        time = time + 1;
                    }
                }
                else if (line.ToString() == " ")
                {
                    //just in the meanwhile - next need to get the delay from the current MorseSymbolEntry Delay NumUpDown and add it to it! -Spaghetti
                    time = time + 1;
                }

                //tone = midi value from the frequencies dictionary - Spaghetti - Important!

                //combining the inputText with itself and adding the tone, time and duration in the right order - should be exactly what we need to save when we find out how to adress the MorseSymbolEntry stuff - Spaghetti - Yeah, almost done, I think this will work!
                inputText = inputText + tone + Environment.NewLine + time + Environment.NewLine + duration + Environment.NewLine + Environment.NewLine;
            }

            //Replace lines with inputText when the problems are solved - then we should be golden -Spaghetti
            File.WriteAllLines(input, lines);
            MessageBox.Show("Hi, input is: " + input + Environment.NewLine + "Lines is: ");
            MessageBox.Show(String.Join("",lines));

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
