namespace MorseComposer.Presentation
{
    partial class MainWindow
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.butt_addChar = new System.Windows.Forms.Button();
            this.butt_remChar = new System.Windows.Forms.Button();
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
            this.lbl_Char.Location = new System.Drawing.Point(22, 17);
            this.lbl_Char.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Char.Name = "lbl_Char";
            this.lbl_Char.Size = new System.Drawing.Size(108, 25);
            this.lbl_Char.TabIndex = 0;
            this.lbl_Char.Text = "Characters";
            // 
            // lbl_Part1
            // 
            this.lbl_Part1.AutoSize = true;
            this.lbl_Part1.Location = new System.Drawing.Point(180, 17);
            this.lbl_Part1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Part1.Name = "lbl_Part1";
            this.lbl_Part1.Size = new System.Drawing.Size(78, 25);
            this.lbl_Part1.TabIndex = 1;
            this.lbl_Part1.Text = "1st Part";
            // 
            // lbl_Part2
            // 
            this.lbl_Part2.AutoSize = true;
            this.lbl_Part2.Location = new System.Drawing.Point(438, 17);
            this.lbl_Part2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Part2.Name = "lbl_Part2";
            this.lbl_Part2.Size = new System.Drawing.Size(85, 25);
            this.lbl_Part2.TabIndex = 2;
            this.lbl_Part2.Text = "2nd Part";
            // 
            // lbl_Part3
            // 
            this.lbl_Part3.AutoSize = true;
            this.lbl_Part3.Location = new System.Drawing.Point(686, 17);
            this.lbl_Part3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Part3.Name = "lbl_Part3";
            this.lbl_Part3.Size = new System.Drawing.Size(80, 25);
            this.lbl_Part3.TabIndex = 3;
            this.lbl_Part3.Text = "3rd Part";
            // 
            // lbl_Part4
            // 
            this.lbl_Part4.AutoSize = true;
            this.lbl_Part4.Location = new System.Drawing.Point(930, 17);
            this.lbl_Part4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Part4.Name = "lbl_Part4";
            this.lbl_Part4.Size = new System.Drawing.Size(79, 25);
            this.lbl_Part4.TabIndex = 4;
            this.lbl_Part4.Text = "4th Part";
            // 
            // lbl_delay
            // 
            this.lbl_delay.AutoSize = true;
            this.lbl_delay.Location = new System.Drawing.Point(1212, 17);
            this.lbl_delay.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_delay.Name = "lbl_delay";
            this.lbl_delay.Size = new System.Drawing.Size(118, 25);
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
            this.comboBox_Char1.Location = new System.Drawing.Point(20, 72);
            this.comboBox_Char1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Char1.Name = "comboBox_Char1";
            this.comboBox_Char1.Size = new System.Drawing.Size(105, 32);
            this.comboBox_Char1.TabIndex = 7;
            this.comboBox_Char1.SelectedIndexChanged += new System.EventHandler(this.comboBox_Char1_SelectedIndexChanged);
            // 
            // comboBox_Char1_Part1
            // 
            this.comboBox_Char1_Part1.DataSource = this.frequenciesBindingSource;
            this.comboBox_Char1_Part1.DisplayMember = "NoteName";
            this.comboBox_Char1_Part1.FormattingEnabled = true;
            this.comboBox_Char1_Part1.Location = new System.Drawing.Point(156, 72);
            this.comboBox_Char1_Part1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Char1_Part1.Name = "comboBox_Char1_Part1";
            this.comboBox_Char1_Part1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Char1_Part1.Size = new System.Drawing.Size(99, 32);
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
            this.comboBox_Char1_Part2.Location = new System.Drawing.Point(422, 72);
            this.comboBox_Char1_Part2.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Char1_Part2.Name = "comboBox_Char1_Part2";
            this.comboBox_Char1_Part2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Char1_Part2.Size = new System.Drawing.Size(99, 32);
            this.comboBox_Char1_Part2.TabIndex = 10;
            this.comboBox_Char1_Part2.ValueMember = "Frequency";
            // 
            // comboBox_Char1_Part3
            // 
            this.comboBox_Char1_Part3.DataSource = this.frequenciesBindingSource;
            this.comboBox_Char1_Part3.DisplayMember = "NoteName";
            this.comboBox_Char1_Part3.FormattingEnabled = true;
            this.comboBox_Char1_Part3.Location = new System.Drawing.Point(664, 72);
            this.comboBox_Char1_Part3.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Char1_Part3.Name = "comboBox_Char1_Part3";
            this.comboBox_Char1_Part3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Char1_Part3.Size = new System.Drawing.Size(99, 32);
            this.comboBox_Char1_Part3.TabIndex = 11;
            this.comboBox_Char1_Part3.ValueMember = "Frequency";
            // 
            // comboBox_Char1_Part4
            // 
            this.comboBox_Char1_Part4.DataSource = this.frequenciesBindingSource;
            this.comboBox_Char1_Part4.DisplayMember = "NoteName";
            this.comboBox_Char1_Part4.FormattingEnabled = true;
            this.comboBox_Char1_Part4.Location = new System.Drawing.Point(908, 72);
            this.comboBox_Char1_Part4.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Char1_Part4.Name = "comboBox_Char1_Part4";
            this.comboBox_Char1_Part4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Char1_Part4.Size = new System.Drawing.Size(99, 32);
            this.comboBox_Char1_Part4.TabIndex = 12;
            this.comboBox_Char1_Part4.ValueMember = "Frequency";
            // 
            // numUpDown_DelayToChar2
            // 
            this.numUpDown_DelayToChar2.Location = new System.Drawing.Point(1021, 74);
            this.numUpDown_DelayToChar2.Margin = new System.Windows.Forms.Padding(6);
            this.numUpDown_DelayToChar2.Maximum = new decimal(new int[] {
            1215752192,
            23,
            0,
            0});
            this.numUpDown_DelayToChar2.Name = "numUpDown_DelayToChar2";
            this.numUpDown_DelayToChar2.Size = new System.Drawing.Size(308, 29);
            this.numUpDown_DelayToChar2.TabIndex = 14;
            this.numUpDown_DelayToChar2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown_DelayToChar2.ThousandsSeparator = true;
            // 
            // lbl_Char1Part1
            // 
            this.lbl_Char1Part1.AutoSize = true;
            this.lbl_Char1Part1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Char1Part1.Location = new System.Drawing.Point(180, 116);
            this.lbl_Char1Part1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Char1Part1.Name = "lbl_Char1Part1";
            this.lbl_Char1Part1.Size = new System.Drawing.Size(75, 39);
            this.lbl_Char1Part1.TabIndex = 15;
            this.lbl_Char1Part1.Text = "null";
            // 
            // lbl_Char1Part2
            // 
            this.lbl_Char1Part2.AutoSize = true;
            this.lbl_Char1Part2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Char1Part2.Location = new System.Drawing.Point(438, 116);
            this.lbl_Char1Part2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Char1Part2.Name = "lbl_Char1Part2";
            this.lbl_Char1Part2.Size = new System.Drawing.Size(75, 39);
            this.lbl_Char1Part2.TabIndex = 16;
            this.lbl_Char1Part2.Text = "null";
            // 
            // lbl_Char1Part3
            // 
            this.lbl_Char1Part3.AutoSize = true;
            this.lbl_Char1Part3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Char1Part3.Location = new System.Drawing.Point(686, 116);
            this.lbl_Char1Part3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Char1Part3.Name = "lbl_Char1Part3";
            this.lbl_Char1Part3.Size = new System.Drawing.Size(75, 39);
            this.lbl_Char1Part3.TabIndex = 17;
            this.lbl_Char1Part3.Text = "null";
            // 
            // lbl_Char1Part4
            // 
            this.lbl_Char1Part4.AutoSize = true;
            this.lbl_Char1Part4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Char1Part4.Location = new System.Drawing.Point(930, 116);
            this.lbl_Char1Part4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Char1Part4.Name = "lbl_Char1Part4";
            this.lbl_Char1Part4.Size = new System.Drawing.Size(75, 39);
            this.lbl_Char1Part4.TabIndex = 18;
            this.lbl_Char1Part4.Text = "null";
            // 
            // button_play
            // 
            this.button_play.Location = new System.Drawing.Point(20, 951);
            this.button_play.Margin = new System.Windows.Forms.Padding(6);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(166, 52);
            this.button_play.TabIndex = 20;
            this.button_play.Text = "PLAY";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.button_play_Click);
            // 
            // lbl_Delay1
            // 
            this.lbl_Delay1.AutoSize = true;
            this.lbl_Delay1.Location = new System.Drawing.Point(286, 17);
            this.lbl_Delay1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Delay1.Name = "lbl_Delay1";
            this.lbl_Delay1.Size = new System.Drawing.Size(118, 25);
            this.lbl_Delay1.TabIndex = 21;
            this.lbl_Delay1.Text = "Delay in MS";
            // 
            // lbl_Delay2
            // 
            this.lbl_Delay2.AutoSize = true;
            this.lbl_Delay2.Location = new System.Drawing.Point(535, 17);
            this.lbl_Delay2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Delay2.Name = "lbl_Delay2";
            this.lbl_Delay2.Size = new System.Drawing.Size(118, 25);
            this.lbl_Delay2.TabIndex = 22;
            this.lbl_Delay2.Text = "Delay in MS";
            // 
            // lbl_Delay3
            // 
            this.lbl_Delay3.AutoSize = true;
            this.lbl_Delay3.Location = new System.Drawing.Point(777, 17);
            this.lbl_Delay3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Delay3.Name = "lbl_Delay3";
            this.lbl_Delay3.Size = new System.Drawing.Size(118, 25);
            this.lbl_Delay3.TabIndex = 23;
            this.lbl_Delay3.Text = "Delay in MS";
            // 
            // numUpDown_DelayChar1Part1
            // 
            this.numUpDown_DelayChar1Part1.Location = new System.Drawing.Point(270, 70);
            this.numUpDown_DelayChar1Part1.Margin = new System.Windows.Forms.Padding(6);
            this.numUpDown_DelayChar1Part1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numUpDown_DelayChar1Part1.Name = "numUpDown_DelayChar1Part1";
            this.numUpDown_DelayChar1Part1.Size = new System.Drawing.Size(141, 29);
            this.numUpDown_DelayChar1Part1.TabIndex = 25;
            this.numUpDown_DelayChar1Part1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown_DelayChar1Part1.ThousandsSeparator = true;
            // 
            // numUpDown_DelayChar1Part2
            // 
            this.numUpDown_DelayChar1Part2.Location = new System.Drawing.Point(535, 70);
            this.numUpDown_DelayChar1Part2.Margin = new System.Windows.Forms.Padding(6);
            this.numUpDown_DelayChar1Part2.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numUpDown_DelayChar1Part2.Name = "numUpDown_DelayChar1Part2";
            this.numUpDown_DelayChar1Part2.Size = new System.Drawing.Size(117, 29);
            this.numUpDown_DelayChar1Part2.TabIndex = 26;
            this.numUpDown_DelayChar1Part2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown_DelayChar1Part2.ThousandsSeparator = true;
            // 
            // numUpDown_DelayChar1Part3
            // 
            this.numUpDown_DelayChar1Part3.Location = new System.Drawing.Point(777, 74);
            this.numUpDown_DelayChar1Part3.Margin = new System.Windows.Forms.Padding(6);
            this.numUpDown_DelayChar1Part3.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numUpDown_DelayChar1Part3.Name = "numUpDown_DelayChar1Part3";
            this.numUpDown_DelayChar1Part3.Size = new System.Drawing.Size(117, 29);
            this.numUpDown_DelayChar1Part3.TabIndex = 27;
            this.numUpDown_DelayChar1Part3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown_DelayChar1Part3.ThousandsSeparator = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 188);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1341, 703);
            this.flowLayoutPanel1.TabIndex = 28;
            // 
            // butt_addChar
            // 
            this.butt_addChar.Location = new System.Drawing.Point(1144, 951);
            this.butt_addChar.Name = "butt_addChar";
            this.butt_addChar.Size = new System.Drawing.Size(185, 52);
            this.butt_addChar.TabIndex = 29;
            this.butt_addChar.Text = "ADD CHAR";
            this.butt_addChar.UseVisualStyleBackColor = true;
            this.butt_addChar.Click += new System.EventHandler(this.butt_addChar_Click);
            // 
            // butt_remChar
            // 
            this.butt_remChar.Location = new System.Drawing.Point(935, 951);
            this.butt_remChar.Name = "butt_remChar";
            this.butt_remChar.Size = new System.Drawing.Size(185, 52);
            this.butt_remChar.TabIndex = 30;
            this.butt_remChar.Text = "REMOVE CHAR";
            this.butt_remChar.UseVisualStyleBackColor = true;
            this.butt_remChar.Click += new System.EventHandler(this.butt_remChar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 1015);
            this.Controls.Add(this.butt_remChar);
            this.Controls.Add(this.butt_addChar);
            this.Controls.Add(this.flowLayoutPanel1);
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
            this.Controls.Add(this.comboBox_Char1);
            this.Controls.Add(this.lbl_delay);
            this.Controls.Add(this.lbl_Part4);
            this.Controls.Add(this.lbl_Part3);
            this.Controls.Add(this.lbl_Part2);
            this.Controls.Add(this.lbl_Part1);
            this.Controls.Add(this.lbl_Char);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button butt_addChar;
        private System.Windows.Forms.Button butt_remChar;
    }
}

