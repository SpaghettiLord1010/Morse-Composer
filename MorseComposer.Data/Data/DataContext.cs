using System;
using System.Diagnostics;
using System.IO;


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
			File.WriteAllLines(input, lines);

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
