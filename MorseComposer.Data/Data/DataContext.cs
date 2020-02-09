using System;
using System.Diagnostics;
using System.IO;

// Note: I still think python interoperation is more trouble than its worth. -Scrivener

namespace MorseComposer.Data
{
    public class DataContext
	{
        public MessageData Message { get; private set; }


        public DataContext()
        {
            Message = new MessageData();
        }

        private const string PythonDirectory = "C:\\Users\\Scrivener07\\AppData\\Local\\Programs\\Python\\Python36-32";


        public void Python(string command, string arguments)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = Path.Combine(PythonDirectory, "python.exe");
            start.Arguments = string.Format("{0} {1}", command, arguments);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
        }


        public void PIP(string command, string arguments)
        {
            ProcessStartInfo start = new ProcessStartInfo();
            start.FileName = Path.Combine(PythonDirectory, "Scripts\\pip.exe");
            start.Arguments = string.Format("{0} {1}", command, arguments);
            start.UseShellExecute = false;
            start.RedirectStandardOutput = true;
            using (Process process = Process.Start(start))
            {
                using (StreamReader reader = process.StandardOutput)
                {
                    string result = reader.ReadToEnd();
                    Console.Write(result);
                }
            }
        }


    }
}
