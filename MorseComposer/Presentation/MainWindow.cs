using System;
using System.Windows.Forms;
using MorseComposer.Data;

namespace MorseComposer.Presentation
{
	public partial class MainWindow : Form
	{

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
					MessageTranslate_TextBox.Text = Program.Data.Message.Translated;
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
			foreach (char character in Program.Data.Message.Text)
			{
				if (Lexicon.Alphabet.TryGetValue(character, out string letter))
				{
					MorseEntry entry = new MorseEntry();
					entry.Character.Text = character.ToString();
					entry.Morse.Text = letter;
					flowLayoutPanel1.Controls.Add(entry);

					foreach (char symbol in letter)
					{
						MorseSymbolEntry symbolEntry = new MorseSymbolEntry();
						symbolEntry.DelayChar1Part1.Value = 1;
						symbolEntry.Char1Part1.Text = symbol.ToString();
						entry.Symbols.Controls.Add(symbolEntry);
					}
				}
			}
		}


		private void PlayButton_OnClick(object sender, EventArgs e)
		{
			Program.Data.Message.Play();
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


	}
}