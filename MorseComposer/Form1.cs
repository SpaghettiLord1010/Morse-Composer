using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;


namespace MorseComposer
{
    

    public partial class Form1 : Form
    {
        Label[] Char1PartArray = new Label[5];
        string MorseCodeChar1 = "";
        Dictionary<string, int> Frequencies = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
            Char1PartArray[0] = this.lbl_Char1Part1;
            Char1PartArray[1] = this.lbl_Char1Part2;
            Char1PartArray[2] = this.lbl_Char1Part3;
            Char1PartArray[3] = this.lbl_Char1Part4;

            
            Frequencies.Add("D1", 37);
            Frequencies.Add("D1#", 39);
            Frequencies.Add("E1", 41);
            Frequencies.Add("F1", 44);
            Frequencies.Add("F1#", 46);
            Frequencies.Add("G1", 49);
            Frequencies.Add("G1#", 52);
            Frequencies.Add("A1", 55);
            Frequencies.Add("A1#", 58);
            Frequencies.Add("B1", 62);
            Frequencies.Add("C2", 65);
            Frequencies.Add("C2#", 69);
            Frequencies.Add("D2", 73);
            Frequencies.Add("D2#", 78);
            Frequencies.Add("E2", 82);
            Frequencies.Add("F2", 87);
            Frequencies.Add("F2#", 93);
            Frequencies.Add("G2", 98);
            Frequencies.Add("G2#", 104);
            Frequencies.Add("A2", 110);
            Frequencies.Add("A2#", 117);
            Frequencies.Add("B2", 124);
            Frequencies.Add("C3", 131);
            Frequencies.Add("C3#", 139);
            Frequencies.Add("D3", 147);
            Frequencies.Add("D3#", 156);
            Frequencies.Add("E3", 165);
            Frequencies.Add("F3", 175);
            Frequencies.Add("F3#", 185);
            Frequencies.Add("G3", 196);
            Frequencies.Add("G3#", 208);
            Frequencies.Add("A3", 220);
            Frequencies.Add("A3#", 233);
            Frequencies.Add("B3", 247);
            Frequencies.Add("C4", 262);
            Frequencies.Add("C4#", 277);
            Frequencies.Add("D4", 294);
            Frequencies.Add("D4#", 311);
            Frequencies.Add("E4", 330);
            Frequencies.Add("F4", 349);
            Frequencies.Add("F4#", 370);
            Frequencies.Add("G4", 392);
            Frequencies.Add("G4#", 415);
            Frequencies.Add("A4", 440);
            Frequencies.Add("A4#", 466);
            Frequencies.Add("B4", 494);
            Frequencies.Add("C5", 523);
            Frequencies.Add("C5#", 554);
            Frequencies.Add("D5", 587);
            Frequencies.Add("D5#", 622);
            Frequencies.Add("E5", 659);
            Frequencies.Add("F5", 699);
            Frequencies.Add("F5#", 740);
            Frequencies.Add("G5", 784);
            Frequencies.Add("G5#", 831);
            Frequencies.Add("A5", 880);
            Frequencies.Add("A5#", 932);
            Frequencies.Add("B5", 988);
            Frequencies.Add("C6", 1047);
            Frequencies.Add("C6#", 1109);
            Frequencies.Add("D6", 1175);
            Frequencies.Add("D6#", 1245);
            Frequencies.Add("E6", 1319);
            Frequencies.Add("F6", 1397);
            Frequencies.Add("F6#", 1480);
            Frequencies.Add("G6", 1568);
            Frequencies.Add("G6#", 1661);
            Frequencies.Add("A6", 1760);
            Frequencies.Add("A6#", 1865);
            Frequencies.Add("B6", 1976);
            Frequencies.Add("C7", 2093);
            Frequencies.Add("C7#", 2217);
            Frequencies.Add("D7", 2349);
            Frequencies.Add("D7#", 2489);
            Frequencies.Add("E7", 2637);
            Frequencies.Add("F7", 2794);
            Frequencies.Add("F7#", 2960);
            Frequencies.Add("G7", 3136);
            Frequencies.Add("G7#", 3322);
            Frequencies.Add("A7", 3520);
            Frequencies.Add("A7#", 3729);
            Frequencies.Add("B7", 3951);
            Frequencies.Add("C8", 4186);
            Frequencies.Add("C8#", 4435);
            Frequencies.Add("D8", 4699);
            Frequencies.Add("D8#", 4978);
            Frequencies.Add("E8", 5274);
            Frequencies.Add("F8", 5588);
            Frequencies.Add("F8#", 5920);
            Frequencies.Add("G8", 6272);
            Frequencies.Add("G8#", 6645);
            Frequencies.Add("A8", 7040);
            Frequencies.Add("A8#", 7459);
            Frequencies.Add("B8", 7902);
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