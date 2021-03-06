﻿using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using System.Runtime;
using System.Threading;


namespace MorseComposer.Data
{

    public class DataContext
    {

        public static bool MyCheckBoxValue;

        public MessageData Message { get; private set; }


        public DataContext()
        {
            Message = new MessageData();
        }


        public void Output()
        {
            bool firstRun = true;
            int time = 0;
            int duration = 0;
            int pause = 0;
            string inputText = ""; //= "0" + Environment.NewLine + "0" + Environment.NewLine + "0" + Environment.NewLine + Environment.NewLine;

            foreach (var symbol in Message.Symbols)
            {

                for (int morseID = 0; morseID < symbol.Code.Length; morseID++)
                {
                    var morseChar = symbol.Code[morseID];
                    var morseTone = symbol.Tone[morseID];
                    var morseDelay = symbol.Delay[morseID];

                    if (MyCheckBoxValue)
                    {
                        switch(morseChar)
                        {
                            case '.':
                                duration = 1;
                                pause = 1;
                                break;
                            case '-':
                                duration = 3;
                                pause = 1;
                                break;
                            case '!':
                                pause = 2;
                                duration = 0;
                                break;
                            case '_':
                                pause = 4;
                                duration = 0;
                                break;
                        }
                        if (morseChar != '!' && morseChar != '_')
                            inputText += morseTone + Environment.NewLine + time + Environment.NewLine + duration + Environment.NewLine + Environment.NewLine;
                        time += duration+pause;
                    }
                    else
                    {

                        if (!firstRun)
                        {
                            if (morseChar == '.')
                            {
                                duration = 1;
                                time = time + (int)morseDelay;

                            }
                            else if (morseChar == '-')
                            {
                                duration = 3;
                                time = time + (int)morseDelay;

                            }
                            else if (morseChar == ' ')
                            {
                                time = time + (int)morseDelay;
                            }

                        }
                        else
                        {
                            firstRun = false;
                            if (morseChar == '.')
                            {
                                duration = 1;
                                time = time + (int)morseDelay;

                            }
                            else if (morseChar == '-')
                            {
                                duration = 3;
                                time = time + (int)morseDelay;

                            }
                            else if (morseChar == ' ')
                            {
                                time = time + (int)morseDelay;
                            }

                        }
                        inputText += morseTone + Environment.NewLine + time + Environment.NewLine + duration + Environment.NewLine + Environment.NewLine;
                    }
                }
                
            }

            string input = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MorseComposer", "temp.txt");

            // TODO: Finish up the input file writer.
            Directory.GetParent(input).Create();

            inputText = inputText + "0" + Environment.NewLine + "0" + Environment.NewLine + "0";
            File.WriteAllText(input, inputText);
            //MessageBox.Show("Hi, input is: " + input + Environment.NewLine + "Lines is: ");
            //MessageBox.Show(inputText);

            if (File.Exists(input))
            {
                if (File.Exists(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MorseComposer", "MorseComposerOutput.mid")))
                {
                    File.Delete(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MorseComposer", "MorseComposerOutput.mid"));
                }

                var directory = Path.GetDirectoryName(Application.ExecutablePath);
                var pythonFile = directory + "\\TextToMid.py";
                File.WriteAllText(directory + "\\temp.bat", "pip install midiutil" + Environment.NewLine + "python " + pythonFile);
                System.Diagnostics.Process.Start(directory + "\\temp.bat");
                MessageBox.Show("Please Wait A Second - The program is making sure that your midiutil-library is installed and the midi file is being created." + Environment.NewLine + Environment.NewLine + "It will take only a few seconds, so please be patient!", "Please Wait A Second!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(2000);
                File.Delete(directory + "\\temp.bat");
                Process.Start("explorer.exe", "/select, " + input);
            }

        }


    }
}
