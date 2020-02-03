using System;
using System.Windows.Forms;
using MorseComposer.Data;
using MorseComposer.Presentation;

namespace MorseComposer
{
    static class Program
    {
        public static DataContext Data { get; private set; }


        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Data = new DataContext();
            Application.Run(new MainWindow());
        }


    }
}
