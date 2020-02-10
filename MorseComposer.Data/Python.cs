using System;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace MorseComposer
{
    /// <summary>
    /// Provides interactions with Python 3.6 32-bit.
    /// </summary>
    public static class Python
	{
        /// <summary>
        /// Current User for Python 3.6 32-bit.
        /// </summary>
        private const string Python32 = @"SOFTWARE\Python\PythonCore\3.6-32\InstallPath";


        /// <summary>
        /// Gets the Python 3.6 installation directory.
        /// </summary>
        /// <returns></returns>
        private static string GetInstallPath()
        {
            using (RegistryKey subkey = Registry.CurrentUser.OpenSubKey(Python32))
            {
                if (subkey != null)
                {
                    if (subkey.GetValue(string.Empty) is string value)
                    {
                        return value;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
        }


        public static bool PIP(string command, string arguments)
        {
            string directory = GetInstallPath();
            if (Directory.Exists(directory))
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = Path.Combine(directory, "Scripts\\pip.exe");
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
                Console.WriteLine(string.Format("Executed: {0} {1}", start.FileName, start.Arguments));
                return true;
            }
            else
            {
                Console.WriteLine(string.Format("Does not exist: {0}", directory));
                return false;
            }
        }


        public static bool Execute(string command, string arguments)
        {
            string directory = GetInstallPath();
            if (Directory.Exists(directory))
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = Path.Combine(directory, "python.exe");
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
                Console.WriteLine(string.Format("Executed: {0} {1}", start.FileName, start.Arguments));
                return true;
            }
            else
            {
                Console.WriteLine(string.Format("Does not exist: {0}", directory));
                return false;
            }
        }


    }
}
