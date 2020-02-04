using System.Linq;
using System.Windows.Forms;

namespace MorseComposer.Presentation
{
    public partial class MorseSymbolEntry : UserControl
	{

        public ComboBox Char1_Part1
        {
            get
            {
                return comboBox_Char1_Part1;
            }
        }

        public NumericUpDown DelayChar1Part1
        {
            get
            {
                return numUpDown_DelayChar1Part1;
            }
        }

        public Label Char1Part1
        {
            get
            {
                return lbl_Char1Part1;
            }
        }


        public MorseSymbolEntry()
		{
			InitializeComponent();
            comboBox_Char1_Part1.DataSource = Program.Data.Frequencies.Keys.ToList();
        }



	}
}
