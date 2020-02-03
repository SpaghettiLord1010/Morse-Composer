using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                lbl_identifiyer.Text = value.ToString();
            }
        }

        public ComboBox Char1
        {
            get
            {
                return comboBox_Char1;
            }
        }


        #region Character_Labels

        public Label Char1Part1
        {
            get
            {
                return lbl_Char1Part1;
            }
        }

        public Label Char1Part2
        {
            get
            {
                return lbl_Char1Part2;
            }
        }

        public Label Char1Part3
        {
            get
            {
                return lbl_Char1Part3;
            }
        }

        public Label Char1Part4
        {
            get
            {
                return lbl_Char1Part4;
            }
        }

        #endregion


        #region Part1

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

        #endregion


        #region Part2

        public ComboBox Char1_Part2
        {
            get
            {
                return comboBox_Char1_Part2;
            }
        }


        public NumericUpDown DelayChar1Part2
        {
            get
            {
                return numUpDown_DelayChar1Part2;
            }
        }

        #endregion



        #region Part3

        public ComboBox Char1_Part3
        {
            get
            {
                return comboBox_Char1_Part3;
            }
        }


        public NumericUpDown DelayChar1Part3
        {
            get
            {
                return numUpDown_DelayChar1Part3;
            }
        }

        #endregion



        #region Part4

        public ComboBox Char1_Part4
        {
            get
            {
                return comboBox_Char1_Part4;
            }
        }


        public NumericUpDown DelayChar1Part4
        {
            get
            {
                return numUpDown_DelayToChar2;
            }
        }

        #endregion



        public MorseEntry()
        {
            InitializeComponent();
            Identifier = Guid.NewGuid();
        }

        private void MorseEntry_Load(object sender, EventArgs e)
        {
            comboBox_Char1_Part1.DataSource = Program.Data.Frequencies.Keys.ToList();
            comboBox_Char1_Part2.DataSource = Program.Data.Frequencies.Keys.ToList();
            comboBox_Char1_Part3.DataSource = Program.Data.Frequencies.Keys.ToList();
            comboBox_Char1_Part4.DataSource = Program.Data.Frequencies.Keys.ToList();

        }

        private void comboBox_Char1_Part1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = comboBox_Char1_Part1.SelectedItem.ToString();
            //comboBox_Char1_Part1.ValueMember = Frequencies[key].ToString();
        }

        private void comboBox_Char1_Part2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = comboBox_Char1_Part2.SelectedItem.ToString();
            //comboBox_Char1_Part1.ValueMember = Frequencies[key].ToString();
        }

        private void comboBox_Char1_Part3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = comboBox_Char1_Part3.SelectedItem.ToString();
            //comboBox_Char1_Part1.ValueMember = Frequencies[key].ToString();

        }

        private void comboBox_Char1_Part4_SelectedIndexChanged(object sender, EventArgs e)
        {
            string key = comboBox_Char1_Part4.SelectedItem.ToString();
            //comboBox_Char1_Part1.ValueMember = Frequencies[key].ToString();
        }
    }
}
