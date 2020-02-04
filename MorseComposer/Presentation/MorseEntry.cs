using System;
using System.Linq;
using System.Windows.Forms;

namespace MorseComposer.Presentation
{
    public partial class MorseEntry : UserControl
    {
        Guid guid;
        public Guid Identifier
        {
            get { return guid; }
            set
            {
                guid = value;
                Identifier_Label.Text = value.ToString();
            }
        }

        public Label Character
        {
            get { return Character_Label; }
        }

        public Label Morse
        {
            get { return Morse_Label; }
        }

        public FlowLayoutPanel Symbols
        {
            get { return this.SymbolPanel; }
        }


        public MorseEntry()
        {
            InitializeComponent();
            Identifier = Guid.NewGuid();
        }


        private void OnLoad(object sender, EventArgs e)
        {

        }


    }
}
