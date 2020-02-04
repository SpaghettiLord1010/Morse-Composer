using System;
using System.Windows.Forms;

namespace MorseComposer.Presentation
{
	public partial class MainWindow : Form
	{
		private readonly Label[] Char1PartArray = new Label[5];

		private string MorseCodeChar1 = "";



		public MainWindow()
		{
			InitializeComponent();
		}


		private void OnLoad(object sender, EventArgs e)
		{
			AddEntry(); // Adds a default entry.

			var entry = GetEntry(0);
			//Char1PartArray[0] = entry.Char1Part1;
			//Char1PartArray[1] = entry.Char1Part2;
			//Char1PartArray[2] = entry.Char1Part3;
			//Char1PartArray[3] = entry.Char1Part4;
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
				if (Program.Data.Letters.TryGetValue(character, out string letter))
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


		private void comboBox_Char1_SelectedIndexChanged(object sender, EventArgs e)
		{
			//var entry = GetEntry(0);
			//PopulateCharacters(entry.Char1);
			//DisplayPartTextChar1();
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


		[Obsolete]
		public void PopulateCharacters(ComboBox comboBox)
		{
			if (comboBox.Text.ToString() == "A")
			{
				MorseCodeChar1 = ".-";
			}
			else if (comboBox.Text.ToString() == "B")
			{
				MorseCodeChar1 = "-...";
			}
			else if (comboBox.Text.ToString() == "C")
			{
				MorseCodeChar1 = "-.-.";
			}
			else if (comboBox.Text.ToString() == "D")
			{
				MorseCodeChar1 = "-..";
			}
			else if (comboBox.Text.ToString() == "E")
			{
				MorseCodeChar1 = ".";
			}
			else if (comboBox.Text.ToString() == "F")
			{
				MorseCodeChar1 = "..-.";
			}
			else if (comboBox.Text.ToString() == "G")
			{
				MorseCodeChar1 = "--.";
			}
			else if (comboBox.Text.ToString() == "H")
			{
				MorseCodeChar1 = "....";
			}
			else if (comboBox.Text.ToString() == "I")
			{
				MorseCodeChar1 = "..";
			}
			else if (comboBox.Text.ToString() == "J")
			{
				MorseCodeChar1 = ".---";
			}
			else if (comboBox.Text.ToString() == "K")
			{
				MorseCodeChar1 = "-.-";
			}
			else if (comboBox.Text.ToString() == "L")
			{
				MorseCodeChar1 = ".-..";
			}
			else if (comboBox.Text.ToString() == "M")
			{
				MorseCodeChar1 = "--";
			}
			else if (comboBox.Text.ToString() == "N")
			{
				MorseCodeChar1 = "-.";
			}
			else if (comboBox.Text.ToString() == "O")
			{
				MorseCodeChar1 = "---";
			}
			else if (comboBox.Text.ToString() == "P")
			{
				MorseCodeChar1 = ".--.";
			}
			else if (comboBox.Text.ToString() == "Q")
			{
				MorseCodeChar1 = "--.-";
			}
			else if (comboBox.Text.ToString() == "R")
			{
				MorseCodeChar1 = ".-.";
			}
			else if (comboBox.Text.ToString() == "S")
			{
				MorseCodeChar1 = "...";
			}
			else if (comboBox.Text.ToString() == "T")
			{
				MorseCodeChar1 = "-";
			}
			else if (comboBox.Text.ToString() == "U")
			{
				MorseCodeChar1 = "..-";
			}
			else if (comboBox.Text.ToString() == "V")
			{
				MorseCodeChar1 = "...-";
			}
			else if (comboBox.Text.ToString() == "W")
			{
				MorseCodeChar1 = ".--";
			}
			else if (comboBox.Text.ToString() == "X")
			{
				MorseCodeChar1 = "-..-";
			}
			else if (comboBox.Text.ToString() == "Y")
			{
				MorseCodeChar1 = "-.--";
			}
			else if (comboBox.Text.ToString() == "Z")
			{
				MorseCodeChar1 = "--..";
			}
		}


		public void DisplayPartTextChar1()
		{
			for (int i = 0; MorseCodeChar1.Length > i; i++)
			{
				if (MorseCodeChar1.Length > i)
				{
					Char1PartArray[i].Text = MorseCodeChar1.Substring(i, 1);
					Char1PartArray[i].Text = "";
				}
			}
		}


		private void button_play_Click(object sender, EventArgs e)
		{
			var entry = GetEntry(0);
			PlayChar1(entry);
		}


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

		private void butt_addChar_Click(object sender, EventArgs e)
		{
			AddEntry();
		}

		private void butt_remChar_Click(object sender, EventArgs e)
		{
			RemoveEntry();
		}



		private void AddEntry()
		{
			MorseEntry myEntryGroup = new MorseEntry();
			flowLayoutPanel1.Controls.Add(myEntryGroup);
		}


		private void RemoveEntry()
		{
			if (flowLayoutPanel1.Controls.Count - 1 > -1)
			{
				int lastEntry = flowLayoutPanel1.Controls.Count - 1;
				flowLayoutPanel1.Controls.RemoveAt(lastEntry);
			}
		}


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