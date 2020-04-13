using System;
using System.Linq;
using System.Windows.Forms;
using MorseComposer.Data;

namespace MorseComposer.Presentation
{
    public partial class MorseSymbolEntry : UserControl
	{

        public ComboBox Char1_Part1
        {
            get { return comboBox_Char1_Part1; }
        }

        public NumericUpDown Delay
        {
            get { return numUpDown_DelayChar1Part1; }
        }

        public GroupBox CodeCharacter
        {
            get { return groupBox1; }
        }


        SymbolData symbol;
        int codeId;

        public MorseSymbolEntry(SymbolData symbol, int codeId)
		{
            this.symbol = symbol;
            this.codeId = codeId;
			InitializeComponent();
            comboBox_Char1_Part1.DataSource = Lexicon.Frequencies.Keys.ToList();
            comboBox_Char1_Part1.SelectedIndexChanged += ComboBox_Char1_Part1_SelectedIndexChanged;

            Delay.ValueChanged += Delay_ValueChanged;
        }

        private void Delay_ValueChanged(object sender, EventArgs e) {
            symbol.Delay[codeId] = (double) Delay.Value;
        }

        private void ComboBox_Char1_Part1_SelectedIndexChanged(object sender, System.EventArgs e) {
            //Applies the Frequency selected for this code
            symbol.Tone[codeId] = Lexicon.Frequencies[comboBox_Char1_Part1.SelectedItem.ToString()].Frequency;
        }

        private void comboBox_Char1_Part1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
        }

        private void groupBox1_Enter(object sender, System.EventArgs e)
        {

        }
    }
}
