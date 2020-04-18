using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using MorseComposer.Data;
using MorseComposer.Presentation;

namespace MorseComposer.Presentation
{

	public partial class MainWindow : Form
	{
        //Need this bool in DataContext.cs, I can do the rest!
        public static bool AutoDelay;
        

        public MainWindow()
		{
			InitializeComponent();
		}


		private void SubmitButton_Click(object sender, EventArgs e)
		{
			flowLayoutPanel1.Controls.Clear();
			MessageEntry_TextBox.Text = MessageEntry_TextBox.Text.ToUpper();

			if (Program.Data.Message.Submit(MessageEntry_TextBox.Text))
			{
				if (Program.Data.Message.Translate())
				{
                    string t = Program.Data.Message.Translated;
                    t = t.Replace("!", "");
                    t = t.Replace("_", "");
                    MessageTranslate_TextBox.Text = t;
                    
					EditButton.Enabled = true;
				}
				else
				{
					MessageTranslate_TextBox.Text = string.Empty;
					EditButton.Enabled = false;
				}
			}
		}


		private void EditButton_Click(object sender, EventArgs e)
		{
			flowLayoutPanel1.Controls.Clear();

			foreach (var symbol in Program.Data.Message.Symbols)
			{
                if (symbol.Code.ToString() != "_")
                {
                    MorseEntry entry = new MorseEntry();
				    entry.Character.Text = symbol.Character.ToString();
                    string t = symbol.Code;
                    t = t.Replace("!", "");
                    t = t.Replace("_", "");
                    entry.Morse.Text = t;
				    flowLayoutPanel1.Controls.Add(entry);


                    for (int i = 0; i < symbol.Code.Length-1; i++)
				    {
					    MorseSymbolEntry symbolEntry = new MorseSymbolEntry(symbol, i);
					    symbolEntry.Delay.Value = 1;
                        t = symbol.Code[i].ToString();
                        t = t.Replace("!", "");
                        t = t.Replace("_", "");
                        symbolEntry.CodeCharacter.Text = t;
					    entry.Symbols.Controls.Add(symbolEntry);
				    }
                }

			}
		}


		private void PlayButton_OnClick(object sender, EventArgs e)
		{
            System.Diagnostics.Process.Start(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "MorseComposer", "MorseComposerOutput.mid"));
        }


		private void AboutWindowMenuItem_OnClick(object sender, EventArgs e)
		{
			new MainAbout().ShowDialog();
		}

		private void DataWindowMenuItem_OnClick(object sender, EventArgs e)
		{
			new DataWindow().Show();
		}

		private void HelpWindowMenuItem_OnClick(object sender, EventArgs e)
		{
			new HelpWindow().Show();
		}

		private void ExitMenuItem_OnClick(object sender, EventArgs e)
		{
			Application.Exit();
		}


		private void ExecuteButton_OnClick(object sender, EventArgs e)
		{
			Program.Data.Output();
            button_play.Enabled = true;
		}

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form MyHelpWindow = new HelpWindow();
            MyHelpWindow.Show();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MyAboutWindow = new MainAbout();
            MyAboutWindow.Show();
        }

        private void dataWindowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form MyDataWindow = new DataWindow();
            MyDataWindow.Show();
        }

        private void checkBox_AutoDelay_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_AutoDelay.Checked)
                MorseComposer.Data.DataContext.MyCheckBoxValue = true;
            else
                MorseComposer.Data.DataContext.MyCheckBoxValue = false;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}