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


		[Obsolete]
		private void OnLoad(object sender, EventArgs e)
		{
		}


		private void SubmitButton_Click(object sender, EventArgs e)
		{
			flowLayoutPanel1.Controls.Clear();
			MessageEntry_TextBox.Text = MessageEntry_TextBox.Text.ToUpper();

			if (Program.Data.Submit(MessageEntry_TextBox.Text))
			{
				if (Program.Data.Translate())
				{
					MessageTranslate_TextBox.Text = Program.Data.Translated;
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
			foreach (char character in Program.Data.Message)
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



		private void AboutMenuItem_OnClick(object sender, EventArgs e)
		{
			new MainAbout().ShowDialog();
		}

		private void DataWindowMenuItem_OnClick(object sender, EventArgs e)
		{
			new DataWindow().Show();
		}

		private void helpToolStripMenuItem_Click(object sender, EventArgs e)
		{
			new HelpWindow().Show();
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}



		private void button_play_Click(object sender, EventArgs e)
		{
			var entry = GetEntry(0);
			PlayChar1(entry);
		}


		[Obsolete]
		public void PlayChar1(MorseEntry entry)
		{
			//if (entry.Character.Text != string.Empty)
			//{
			//	//Playing the first note - first part of the character
			//	if (MorseCodeChar1.Substring(0, 1) == ".")
			//	{
			//		Console.Beep(Convert.ToInt32(entry.Char1_Part1.SelectedValue), 200);
			//	}
			//	else if (MorseCodeChar1.Substring(0, 1) == "-")
			//	{
			//		Console.Beep(Convert.ToInt32(entry.Char1_Part1.SelectedValue), 600);
			//	}
			//	System.Threading.Thread.Sleep((int)entry.DelayChar1Part1.Value);

			//	//Playing the second note - second part of the character
			//	if (MorseCodeChar1.Substring(1, 1) == ".")
			//	{
			//		Console.Beep(Convert.ToInt32(entry.Char1_Part2.SelectedValue), 200);
			//	}
			//	else if (MorseCodeChar1.Substring(1, 1) == "-")
			//	{
			//		Console.Beep(Convert.ToInt32(entry.Char1_Part2.SelectedValue), 600);
			//	}
			//	System.Threading.Thread.Sleep((int)entry.DelayChar1Part2.Value);

			//	//Playing the third note - third part of the character
			//	if (MorseCodeChar1.Substring(2, 1) == ".")
			//	{
			//		Console.Beep(Convert.ToInt32(entry.Char1_Part3.SelectedValue), 200);
			//	}
			//	else if (MorseCodeChar1.Substring(2, 1) == "-")
			//	{
			//		Console.Beep(Convert.ToInt32(entry.Char1_Part3.SelectedValue), 600);
			//	}
			//	System.Threading.Thread.Sleep((int)entry.DelayChar1Part3.Value);

			//	//Playing the fourth note - fourth part of the character
			//	if (MorseCodeChar1.Substring(3, 1) == ".")
			//	{
			//		Console.Beep(Convert.ToInt32(entry.Char1_Part4.SelectedValue), 200);
			//	}
			//	else if (MorseCodeChar1.Substring(3, 1) == "-")
			//	{
			//		Console.Beep(Convert.ToInt32(entry.Char1_Part4.SelectedValue), 600);
			//	}
			//	System.Threading.Thread.Sleep((int)entry.DelayChar1Part4.Value);
			//}
		}


		[Obsolete]
		private void butt_addChar_Click(object sender, EventArgs e)
		{
			AddEntry();
		}


		[Obsolete]
		private void butt_remChar_Click(object sender, EventArgs e)
		{
			RemoveEntry();
		}


		[Obsolete]
		private void AddEntry()
		{
			MorseEntry myEntryGroup = new MorseEntry();
			flowLayoutPanel1.Controls.Add(myEntryGroup);
		}


		[Obsolete]
		private void RemoveEntry()
		{
			if (flowLayoutPanel1.Controls.Count - 1 > -1)
			{
				int lastEntry = flowLayoutPanel1.Controls.Count - 1;
				flowLayoutPanel1.Controls.RemoveAt(lastEntry);
			}
		}


		[Obsolete]
		private MorseEntry GetEntry(int index)
		{
			if (flowLayoutPanel1.Controls.Count > 0)
			{
				return flowLayoutPanel1.Controls[index] as MorseEntry;
			}
			else
			{
				throw new IndexOutOfRangeException("The flow layout has no entries.");
			}
		}


	}
}