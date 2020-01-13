namespace MorseComposer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_Char = new System.Windows.Forms.Label();
            this.lbl_Part1 = new System.Windows.Forms.Label();
            this.lbl_Part2 = new System.Windows.Forms.Label();
            this.lbl_Part3 = new System.Windows.Forms.Label();
            this.lbl_Part4 = new System.Windows.Forms.Label();
            this.lbl_delay = new System.Windows.Forms.Label();
            this.comboBox_Char1 = new System.Windows.Forms.ComboBox();
            this.comboBox_Char2 = new System.Windows.Forms.ComboBox();
            this.comboBox_Char1_Part1 = new System.Windows.Forms.ComboBox();
            this.frequenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.frequencySheet1DataSet = new MorseComposer.FrequencySheet1DataSet();
            this.frequenciesTableAdapter = new MorseComposer.FrequencySheet1DataSetTableAdapters.FrequenciesTableAdapter();
            this.comboBox_Char1_Part2 = new System.Windows.Forms.ComboBox();
            this.comboBox_Char1_Part3 = new System.Windows.Forms.ComboBox();
            this.comboBox_Char1_Part4 = new System.Windows.Forms.ComboBox();
            this.numUpDown_DelayToChar2 = new System.Windows.Forms.NumericUpDown();
            this.lbl_Char1Part1 = new System.Windows.Forms.Label();
            this.lbl_Char1Part2 = new System.Windows.Forms.Label();
            this.lbl_Char1Part3 = new System.Windows.Forms.Label();
            this.lbl_Char1Part4 = new System.Windows.Forms.Label();
            this.button_play = new System.Windows.Forms.Button();
            this.lbl_Delay1 = new System.Windows.Forms.Label();
            this.lbl_Delay2 = new System.Windows.Forms.Label();
            this.lbl_Delay3 = new System.Windows.Forms.Label();
            this.numUpDown_DelayChar1Part1 = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_DelayChar1Part2 = new System.Windows.Forms.NumericUpDown();
            this.numUpDown_DelayChar1Part3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.frequenciesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySheet1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_DelayToChar2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_DelayChar1Part1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_DelayChar1Part2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_DelayChar1Part3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Char
            // 
            this.lbl_Char.AutoSize = true;
            this.lbl_Char.Location = new System.Drawing.Point(12, 9);
            this.lbl_Char.Name = "lbl_Char";
            this.lbl_Char.Size = new System.Drawing.Size(58, 13);
            this.lbl_Char.TabIndex = 0;
            this.lbl_Char.Text = "Characters";
            // 
            // lbl_Part1
            // 
            this.lbl_Part1.AutoSize = true;
            this.lbl_Part1.Location = new System.Drawing.Point(98, 9);
            this.lbl_Part1.Name = "lbl_Part1";
            this.lbl_Part1.Size = new System.Drawing.Size(43, 13);
            this.lbl_Part1.TabIndex = 1;
            this.lbl_Part1.Text = "1st Part";
            // 
            // lbl_Part2
            // 
            this.lbl_Part2.AutoSize = true;
            this.lbl_Part2.Location = new System.Drawing.Point(239, 9);
            this.lbl_Part2.Name = "lbl_Part2";
            this.lbl_Part2.Size = new System.Drawing.Size(47, 13);
            this.lbl_Part2.TabIndex = 2;
            this.lbl_Part2.Text = "2nd Part";
            // 
            // lbl_Part3
            // 
            this.lbl_Part3.AutoSize = true;
            this.lbl_Part3.Location = new System.Drawing.Point(374, 9);
            this.lbl_Part3.Name = "lbl_Part3";
            this.lbl_Part3.Size = new System.Drawing.Size(44, 13);
            this.lbl_Part3.TabIndex = 3;
            this.lbl_Part3.Text = "3rd Part";
            // 
            // lbl_Part4
            // 
            this.lbl_Part4.AutoSize = true;
            this.lbl_Part4.Location = new System.Drawing.Point(507, 9);
            this.lbl_Part4.Name = "lbl_Part4";
            this.lbl_Part4.Size = new System.Drawing.Size(44, 13);
            this.lbl_Part4.TabIndex = 4;
            this.lbl_Part4.Text = "4th Part";
            // 
            // lbl_delay
            // 
            this.lbl_delay.AutoSize = true;
            this.lbl_delay.Location = new System.Drawing.Point(661, 9);
            this.lbl_delay.Name = "lbl_delay";
            this.lbl_delay.Size = new System.Drawing.Size(64, 13);
            this.lbl_delay.TabIndex = 6;
            this.lbl_delay.Text = "Delay in MS";
            // 
            // comboBox_Char1
            // 
            this.comboBox_Char1.FormattingEnabled = true;
            this.comboBox_Char1.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox_Char1.Location = new System.Drawing.Point(11, 39);
            this.comboBox_Char1.Name = "comboBox_Char1";
            this.comboBox_Char1.Size = new System.Drawing.Size(59, 21);
            this.comboBox_Char1.TabIndex = 7;
            this.comboBox_Char1.SelectedIndexChanged += new System.EventHandler(this.comboBox_Char1_SelectedIndexChanged);
            // 
            // comboBox_Char2
            // 
            this.comboBox_Char2.FormattingEnabled = true;
            this.comboBox_Char2.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z"});
            this.comboBox_Char2.Location = new System.Drawing.Point(11, 99);
            this.comboBox_Char2.Name = "comboBox_Char2";
            this.comboBox_Char2.Size = new System.Drawing.Size(59, 21);
            this.comboBox_Char2.TabIndex = 8;
            // 
            // comboBox_Char1_Part1
            // 
            this.comboBox_Char1_Part1.DataSource = this.frequenciesBindingSource;
            this.comboBox_Char1_Part1.DisplayMember = "NoteName";
            this.comboBox_Char1_Part1.FormattingEnabled = true;
            this.comboBox_Char1_Part1.Location = new System.Drawing.Point(85, 39);
            this.comboBox_Char1_Part1.Name = "comboBox_Char1_Part1";
            this.comboBox_Char1_Part1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Char1_Part1.Size = new System.Drawing.Size(56, 21);
            this.comboBox_Char1_Part1.TabIndex = 9;
            this.comboBox_Char1_Part1.ValueMember = "Frequency";
            // 
            // frequenciesBindingSource
            // 
            this.frequenciesBindingSource.DataMember = "Frequencies";
            this.frequenciesBindingSource.DataSource = this.frequencySheet1DataSet;
            // 
            // frequencySheet1DataSet
            // 
            this.frequencySheet1DataSet.DataSetName = "FrequencySheet1DataSet";
            this.frequencySheet1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // frequenciesTableAdapter
            // 
            this.frequenciesTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox_Char1_Part2
            // 
            this.comboBox_Char1_Part2.DataSource = this.frequenciesBindingSource;
            this.comboBox_Char1_Part2.DisplayMember = "NoteName";
            this.comboBox_Char1_Part2.FormattingEnabled = true;
            this.comboBox_Char1_Part2.Location = new System.Drawing.Point(230, 39);
            this.comboBox_Char1_Part2.Name = "comboBox_Char1_Part2";
            this.comboBox_Char1_Part2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Char1_Part2.Size = new System.Drawing.Size(56, 21);
            this.comboBox_Char1_Part2.TabIndex = 10;
            this.comboBox_Char1_Part2.ValueMember = "Frequency";
            // 
            // comboBox_Char1_Part3
            // 
            this.comboBox_Char1_Part3.DataSource = this.frequenciesBindingSource;
            this.comboBox_Char1_Part3.DisplayMember = "NoteName";
            this.comboBox_Char1_Part3.FormattingEnabled = true;
            this.comboBox_Char1_Part3.Location = new System.Drawing.Point(362, 39);
            this.comboBox_Char1_Part3.Name = "comboBox_Char1_Part3";
            this.comboBox_Char1_Part3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Char1_Part3.Size = new System.Drawing.Size(56, 21);
            this.comboBox_Char1_Part3.TabIndex = 11;
            this.comboBox_Char1_Part3.ValueMember = "Frequency";
            // 
            // comboBox_Char1_Part4
            // 
            this.comboBox_Char1_Part4.DataSource = this.frequenciesBindingSource;
            this.comboBox_Char1_Part4.DisplayMember = "NoteName";
            this.comboBox_Char1_Part4.FormattingEnabled = true;
            this.comboBox_Char1_Part4.Location = new System.Drawing.Point(495, 39);
            this.comboBox_Char1_Part4.Name = "comboBox_Char1_Part4";
            this.comboBox_Char1_Part4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Char1_Part4.Size = new System.Drawing.Size(56, 21);
            this.comboBox_Char1_Part4.TabIndex = 12;
            this.comboBox_Char1_Part4.ValueMember = "Frequency";
            // 
            // numUpDown_DelayToChar2
            // 
            this.numUpDown_DelayToChar2.Location = new System.Drawing.Point(557, 40);
            this.numUpDown_DelayToChar2.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numUpDown_DelayToChar2.Name = "numUpDown_DelayToChar2";
            this.numUpDown_DelayToChar2.Size = new System.Drawing.Size(168, 20);
            this.numUpDown_DelayToChar2.TabIndex = 14;
            this.numUpDown_DelayToChar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown_DelayToChar2.ThousandsSeparator = true;
            // 
            // lbl_Char1Part1
            // 
            this.lbl_Char1Part1.AutoSize = true;
            this.lbl_Char1Part1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Char1Part1.Location = new System.Drawing.Point(98, 63);
            this.lbl_Char1Part1.Name = "lbl_Char1Part1";
            this.lbl_Char1Part1.Size = new System.Drawing.Size(44, 24);
            this.lbl_Char1Part1.TabIndex = 15;
            this.lbl_Char1Part1.Text = "null";
            // 
            // lbl_Char1Part2
            // 
            this.lbl_Char1Part2.AutoSize = true;
            this.lbl_Char1Part2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Char1Part2.Location = new System.Drawing.Point(239, 63);
            this.lbl_Char1Part2.Name = "lbl_Char1Part2";
            this.lbl_Char1Part2.Size = new System.Drawing.Size(44, 24);
            this.lbl_Char1Part2.TabIndex = 16;
            this.lbl_Char1Part2.Text = "null";
            // 
            // lbl_Char1Part3
            // 
            this.lbl_Char1Part3.AutoSize = true;
            this.lbl_Char1Part3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Char1Part3.Location = new System.Drawing.Point(374, 63);
            this.lbl_Char1Part3.Name = "lbl_Char1Part3";
            this.lbl_Char1Part3.Size = new System.Drawing.Size(44, 24);
            this.lbl_Char1Part3.TabIndex = 17;
            this.lbl_Char1Part3.Text = "null";
            // 
            // lbl_Char1Part4
            // 
            this.lbl_Char1Part4.AutoSize = true;
            this.lbl_Char1Part4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Char1Part4.Location = new System.Drawing.Point(507, 63);
            this.lbl_Char1Part4.Name = "lbl_Char1Part4";
            this.lbl_Char1Part4.Size = new System.Drawing.Size(44, 24);
            this.lbl_Char1Part4.TabIndex = 18;
            this.lbl_Char1Part4.Text = "null";
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(11, 515);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(75, 23);
            this.button_play.TabIndex = 20;
            this.button_play.Text = "PLAY";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // lbl_Delay1
            // 
            this.lbl_Delay1.AutoSize = true;
            this.lbl_Delay1.Location = new System.Drawing.Point(156, 9);
            this.lbl_Delay1.Name = "lbl_Delay1";
            this.lbl_Delay1.Size = new System.Drawing.Size(64, 13);
            this.lbl_Delay1.TabIndex = 21;
            this.lbl_Delay1.Text = "Delay in MS";
            // 
            // lbl_Delay2
            // 
            this.lbl_Delay2.AutoSize = true;
            this.lbl_Delay2.Location = new System.Drawing.Point(292, 9);
            this.lbl_Delay2.Name = "lbl_Delay2";
            this.lbl_Delay2.Size = new System.Drawing.Size(64, 13);
            this.lbl_Delay2.TabIndex = 22;
            this.lbl_Delay2.Text = "Delay in MS";
            // 
            // lbl_Delay3
            // 
            this.lbl_Delay3.AutoSize = true;
            this.lbl_Delay3.Location = new System.Drawing.Point(424, 9);
            this.lbl_Delay3.Name = "lbl_Delay3";
            this.lbl_Delay3.Size = new System.Drawing.Size(64, 13);
            this.lbl_Delay3.TabIndex = 23;
            this.lbl_Delay3.Text = "Delay in MS";
            // 
            // numUpDown_DelayChar1Part1
            // 
            this.numUpDown_DelayChar1Part1.Location = new System.Drawing.Point(147, 38);
            this.numUpDown_DelayChar1Part1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numUpDown_DelayChar1Part1.Name = "numUpDown_DelayChar1Part1";
            this.numUpDown_DelayChar1Part1.Size = new System.Drawing.Size(77, 20);
            this.numUpDown_DelayChar1Part1.TabIndex = 25;
            this.numUpDown_DelayChar1Part1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown_DelayChar1Part1.ThousandsSeparator = true;
            // 
            // numUpDown_DelayChar1Part2
            // 
            this.numUpDown_DelayChar1Part2.Location = new System.Drawing.Point(292, 38);
            this.numUpDown_DelayChar1Part2.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numUpDown_DelayChar1Part2.Name = "numUpDown_DelayChar1Part2";
            this.numUpDown_DelayChar1Part2.Size = new System.Drawing.Size(64, 20);
            this.numUpDown_DelayChar1Part2.TabIndex = 26;
            this.numUpDown_DelayChar1Part2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown_DelayChar1Part2.ThousandsSeparator = true;
            // 
            // numUpDown_DelayChar1Part3
            // 
            this.numUpDown_DelayChar1Part3.Location = new System.Drawing.Point(424, 40);
            this.numUpDown_DelayChar1Part3.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numUpDown_DelayChar1Part3.Name = "numUpDown_DelayChar1Part3";
            this.numUpDown_DelayChar1Part3.Size = new System.Drawing.Size(64, 20);
            this.numUpDown_DelayChar1Part3.TabIndex = 27;
            this.numUpDown_DelayChar1Part3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown_DelayChar1Part3.ThousandsSeparator = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 550);
            this.Controls.Add(this.numUpDown_DelayChar1Part3);
            this.Controls.Add(this.numUpDown_DelayChar1Part2);
            this.Controls.Add(this.numUpDown_DelayChar1Part1);
            this.Controls.Add(this.lbl_Delay3);
            this.Controls.Add(this.lbl_Delay2);
            this.Controls.Add(this.lbl_Delay1);
            this.Controls.Add(this.button_play);
            this.Controls.Add(this.lbl_Char1Part4);
            this.Controls.Add(this.lbl_Char1Part3);
            this.Controls.Add(this.lbl_Char1Part2);
            this.Controls.Add(this.lbl_Char1Part1);
            this.Controls.Add(this.numUpDown_DelayToChar2);
            this.Controls.Add(this.comboBox_Char1_Part4);
            this.Controls.Add(this.comboBox_Char1_Part3);
            this.Controls.Add(this.comboBox_Char1_Part2);
            this.Controls.Add(this.comboBox_Char1_Part1);
            this.Controls.Add(this.comboBox_Char2);
            this.Controls.Add(this.comboBox_Char1);
            this.Controls.Add(this.lbl_delay);
            this.Controls.Add(this.lbl_Part4);
            this.Controls.Add(this.lbl_Part3);
            this.Controls.Add(this.lbl_Part2);
            this.Controls.Add(this.lbl_Part1);
            this.Controls.Add(this.lbl_Char);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Morse-Composer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.frequenciesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.frequencySheet1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_DelayToChar2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_DelayChar1Part1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_DelayChar1Part2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_DelayChar1Part3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Char;
        private System.Windows.Forms.Label lbl_Part1;
        private System.Windows.Forms.Label lbl_Part2;
        private System.Windows.Forms.Label lbl_Part3;
        private System.Windows.Forms.Label lbl_Part4;
        private System.Windows.Forms.Label lbl_delay;
        private System.Windows.Forms.ComboBox comboBox_Char1;
        private System.Windows.Forms.ComboBox comboBox_Char2;
        private System.Windows.Forms.ComboBox comboBox_Char1_Part1;
        private FrequencySheet1DataSet frequencySheet1DataSet;
        private System.Windows.Forms.BindingSource frequenciesBindingSource;
        private FrequencySheet1DataSetTableAdapters.FrequenciesTableAdapter frequenciesTableAdapter;
        private System.Windows.Forms.ComboBox comboBox_Char1_Part2;
        private System.Windows.Forms.ComboBox comboBox_Char1_Part3;
        private System.Windows.Forms.ComboBox comboBox_Char1_Part4;
        private System.Windows.Forms.NumericUpDown numUpDown_DelayToChar2;
        private System.Windows.Forms.Label lbl_Char1Part1;
        private System.Windows.Forms.Label lbl_Char1Part2;
        private System.Windows.Forms.Label lbl_Char1Part3;
        private System.Windows.Forms.Label lbl_Char1Part4;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.Label lbl_Delay1;
        private System.Windows.Forms.Label lbl_Delay2;
        private System.Windows.Forms.Label lbl_Delay3;
        private System.Windows.Forms.NumericUpDown numUpDown_DelayChar1Part1;
        private System.Windows.Forms.NumericUpDown numUpDown_DelayChar1Part2;
        private System.Windows.Forms.NumericUpDown numUpDown_DelayChar1Part3;
    }
}

