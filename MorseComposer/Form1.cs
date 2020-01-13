using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MorseComposer
{
    public partial class Form1 : Form
    {
        Label[] Char1PartArray = new Label[5];
        string MorseCodeChar1 = "";
        public Form1()
        {
            InitializeComponent();
            Char1PartArray[0] = this.lbl_Char1Part1;
            Char1PartArray[1] = this.lbl_Char1Part2;
            Char1PartArray[2] = this.lbl_Char1Part3;
            Char1PartArray[3] = this.lbl_Char1Part4;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: Diese Codezeile lädt Daten in die Tabelle "frequencySheet1DataSet.Frequencies". Sie können sie bei Bedarf verschieben oder entfernen.
            this.frequenciesTableAdapter.Fill(this.frequencySheet1DataSet.Frequencies);

        }

        private void comboBox_Char1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckComboBox1();
            CheckComboBox2();
            DisplayPartTextChar1();
        }
        public void CheckComboBox1()
        {
            if (comboBox_Char1.Text.ToString() == "A")
            {
                MorseCodeChar1 = ".-";
            }
            else if (comboBox_Char1.Text.ToString() == "B")
            {
                MorseCodeChar1 = "-...";
            }
            else if (comboBox_Char1.Text.ToString() == "C")
            {
                MorseCodeChar1 = "-.-.";
            }
            else if (comboBox_Char1.Text.ToString() == "D")
            {
                MorseCodeChar1 = "-..";
            }
            else if (comboBox_Char1.Text.ToString() == "E")
            {
                MorseCodeChar1 = ".";
            }
            else if (comboBox_Char1.Text.ToString() == "F")
            {
                MorseCodeChar1 = "..-.";
            }
            else if (comboBox_Char1.Text.ToString() == "G")
            {
                MorseCodeChar1 = "--.";
            }
            else if (comboBox_Char1.Text.ToString() == "H")
            {
                MorseCodeChar1 = "....";
            }
            else if (comboBox_Char1.Text.ToString() == "I")
            {
                MorseCodeChar1 = "..";
            }
            else if (comboBox_Char1.Text.ToString() == "J")
            {
                MorseCodeChar1 = ".---";
            }
            else if (comboBox_Char1.Text.ToString() == "K")
            {
                MorseCodeChar1 = "-.-";
            }
            else if (comboBox_Char1.Text.ToString() == "L")
            {
                MorseCodeChar1 = ".-..";
            }
            else if (comboBox_Char1.Text.ToString() == "M")
            {
                MorseCodeChar1 = "--";
            }
            else if (comboBox_Char1.Text.ToString() == "N")
            {
                MorseCodeChar1 = "-.";
            }
            else if (comboBox_Char1.Text.ToString() == "O")
            {
                MorseCodeChar1 = "---";
            }
            else if (comboBox_Char1.Text.ToString() == "P")
            {
                MorseCodeChar1 = ".--.";
            }
            else if (comboBox_Char1.Text.ToString() == "Q")
            {
                MorseCodeChar1 = "--.-";
            }
            else if (comboBox_Char1.Text.ToString() == "R")
            {
                MorseCodeChar1 = ".-.";
            }
            else if (comboBox_Char1.Text.ToString() == "S")
            {
                MorseCodeChar1 = "...";
            }
            else if (comboBox_Char1.Text.ToString() == "T")
            {
                MorseCodeChar1 = "-";
            }
            else if (comboBox_Char1.Text.ToString() == "U")
            {
                MorseCodeChar1 = "..-";
            }
            else if (comboBox_Char1.Text.ToString() == "V")
            {
                MorseCodeChar1 = "...-";
            }
            else if (comboBox_Char1.Text.ToString() == "W")
            {
                MorseCodeChar1 = ".--";
            }
            else if (comboBox_Char1.Text.ToString() == "X")
            {
                MorseCodeChar1 = "-..-";
            }
            else if (comboBox_Char1.Text.ToString() == "Y")
            {
                MorseCodeChar1 = "-.--";
            }
            else if (comboBox_Char1.Text.ToString() == "Z")
            {
                MorseCodeChar1 = "--..";
            }
        }
        public void CheckComboBox2()
        {
            if (comboBox_Char2.Text.ToString() == "A")
            {
                MorseCodeChar1 = ".-";
            }
            else if (comboBox_Char2.Text.ToString() == "B")
            {
                MorseCodeChar1 = "-...";
            }
            else if (comboBox_Char2.Text.ToString() == "C")
            {
                MorseCodeChar1 = "-.-.";
            }
            else if (comboBox_Char2.Text.ToString() == "D")
            {
                MorseCodeChar1 = "-..";
            }
            else if (comboBox_Char2.Text.ToString() == "E")
            {
                MorseCodeChar1 = ".";
            }
            else if (comboBox_Char2.Text.ToString() == "F")
            {
                MorseCodeChar1 = "..-.";
            }
            else if (comboBox_Char2.Text.ToString() == "G")
            {
                MorseCodeChar1 = "--.";
            }
            else if (comboBox_Char2.Text.ToString() == "H")
            {
                MorseCodeChar1 = "....";
            }
            else if (comboBox_Char2.Text.ToString() == "I")
            {
                MorseCodeChar1 = "..";
            }
            else if (comboBox_Char2.Text.ToString() == "J")
            {
                MorseCodeChar1 = ".---";
            }
            else if (comboBox_Char2.Text.ToString() == "K")
            {
                MorseCodeChar1 = "-.-";
            }
            else if (comboBox_Char2.Text.ToString() == "L")
            {
                MorseCodeChar1 = ".-..";
            }
            else if (comboBox_Char2.Text.ToString() == "M")
            {
                MorseCodeChar1 = "--";
            }
            else if (comboBox_Char2.Text.ToString() == "N")
            {
                MorseCodeChar1 = "-.";
            }
            else if (comboBox_Char2.Text.ToString() == "O")
            {
                MorseCodeChar1 = "---";
            }
            else if (comboBox_Char2.Text.ToString() == "P")
            {
                MorseCodeChar1 = ".--.";
            }
            else if (comboBox_Char2.Text.ToString() == "Q")
            {
                MorseCodeChar1 = "--.-";
            }
            else if (comboBox_Char2.Text.ToString() == "R")
            {
                MorseCodeChar1 = ".-.";
            }
            else if (comboBox_Char2.Text.ToString() == "S")
            {
                MorseCodeChar1 = "...";
            }
            else if (comboBox_Char2.Text.ToString() == "T")
            {
                MorseCodeChar1 = "-";
            }
            else if (comboBox_Char2.Text.ToString() == "U")
            {
                MorseCodeChar1 = "..-";
            }
            else if (comboBox_Char2.Text.ToString() == "V")
            {
                MorseCodeChar1 = "...-";
            }
            else if (comboBox_Char2.Text.ToString() == "W")
            {
                MorseCodeChar1 = ".--";
            }
            else if (comboBox_Char2.Text.ToString() == "X")
            {
                MorseCodeChar1 = "-..-";
            }
            else if (comboBox_Char2.Text.ToString() == "Y")
            {
                MorseCodeChar1 = "-.--";
            }
            else if (comboBox_Char2.Text.ToString() == "Z")
            {
                MorseCodeChar1 = "--..";
            }
        }
        public void DisplayPartTextChar1()
        {
            for (int i = 0;  MorseCodeChar1.Length > i; i++)
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
            PlayChar1();
        }

        public void PlayChar1()
        {
            if (comboBox_Char1.Text != "")
            {
                //Playing the first note - first part of the character
                if (MorseCodeChar1.Substring(0, 1) == ".")
                {
                    Console.Beep(Convert.ToInt32(comboBox_Char1_Part1.SelectedValue), 200);
                }
                else if (MorseCodeChar1.Substring(0, 1) == "-")
                {
                    Console.Beep(Convert.ToInt32(comboBox_Char1_Part1.SelectedValue), 600);
                }
                System.Threading.Thread.Sleep((int)numUpDown_DelayChar1Part1.Value);

                //Playing the second note - second part of the character
                if (MorseCodeChar1.Substring(1, 1) == ".")
                {
                    Console.Beep(Convert.ToInt32(comboBox_Char1_Part2.SelectedValue), 200);
                }
                else if (MorseCodeChar1.Substring(1, 1) == "-")
                {
                    Console.Beep(Convert.ToInt32(comboBox_Char1_Part2.SelectedValue), 600);
                }
                System.Threading.Thread.Sleep((int)numUpDown_DelayChar1Part2.Value);

                //Playing the third note - third part of the character
                if (MorseCodeChar1.Substring(2, 1) == ".")
                {
                    Console.Beep(Convert.ToInt32(comboBox_Char1_Part3.SelectedValue), 200);
                }
                else if (MorseCodeChar1.Substring(2, 1) == "-")
                {
                    Console.Beep(Convert.ToInt32(comboBox_Char1_Part3.SelectedValue), 600);
                }
                System.Threading.Thread.Sleep((int)numUpDown_DelayChar1Part3.Value);

                //Playing the fourth note - fourth part of the character
                if (MorseCodeChar1.Substring(3, 1) == ".")
                {
                    Console.Beep(Convert.ToInt32(comboBox_Char1_Part4.SelectedValue), 200);
                }
                else if (MorseCodeChar1.Substring(3, 1) == "-")
                {
                    Console.Beep(Convert.ToInt32(comboBox_Char1_Part4.SelectedValue), 600);
                }
                System.Threading.Thread.Sleep((int)numUpDown_DelayToChar2.Value);
            }

        }
    }
}