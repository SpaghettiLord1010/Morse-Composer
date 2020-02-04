namespace MorseComposer.Presentation
{
	partial class MorseSymbolEntry
	{
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.numUpDown_DelayChar1Part1 = new System.Windows.Forms.NumericUpDown();
			this.lbl_Char1Part1 = new System.Windows.Forms.Label();
			this.comboBox_Char1_Part1 = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_DelayChar1Part1)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// numUpDown_DelayChar1Part1
			// 
			this.numUpDown_DelayChar1Part1.Location = new System.Drawing.Point(65, 16);
			this.numUpDown_DelayChar1Part1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
			this.numUpDown_DelayChar1Part1.Name = "numUpDown_DelayChar1Part1";
			this.numUpDown_DelayChar1Part1.Size = new System.Drawing.Size(77, 20);
			this.numUpDown_DelayChar1Part1.TabIndex = 64;
			this.numUpDown_DelayChar1Part1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.numUpDown_DelayChar1Part1.ThousandsSeparator = true;
			// 
			// lbl_Char1Part1
			// 
			this.lbl_Char1Part1.AutoSize = true;
			this.lbl_Char1Part1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Char1Part1.Location = new System.Drawing.Point(3, 40);
			this.lbl_Char1Part1.Name = "lbl_Char1Part1";
			this.lbl_Char1Part1.Size = new System.Drawing.Size(44, 24);
			this.lbl_Char1Part1.TabIndex = 63;
			this.lbl_Char1Part1.Text = "null";
			// 
			// comboBox_Char1_Part1
			// 
			this.comboBox_Char1_Part1.DisplayMember = "NoteName";
			this.comboBox_Char1_Part1.FormattingEnabled = true;
			this.comboBox_Char1_Part1.Location = new System.Drawing.Point(3, 16);
			this.comboBox_Char1_Part1.Name = "comboBox_Char1_Part1";
			this.comboBox_Char1_Part1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.comboBox_Char1_Part1.Size = new System.Drawing.Size(56, 21);
			this.comboBox_Char1_Part1.TabIndex = 62;
			this.comboBox_Char1_Part1.ValueMember = "Frequency";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(65, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 13);
			this.label2.TabIndex = 66;
			this.label2.Text = "Delay (MS)";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(41, 13);
			this.label1.TabIndex = 65;
			this.label1.Text = "Symbol";
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.lbl_Char1Part1, 0, 2);
			this.tableLayoutPanel1.Controls.Add(this.numUpDown_DelayChar1Part1, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.comboBox_Char1_Part1, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(145, 64);
			this.tableLayoutPanel1.TabIndex = 67;
			// 
			// MorseSymbolEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MorseSymbolEntry";
			this.Size = new System.Drawing.Size(151, 70);
			((System.ComponentModel.ISupportInitialize)(this.numUpDown_DelayChar1Part1)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numUpDown_DelayChar1Part1;
		private System.Windows.Forms.Label lbl_Char1Part1;
		private System.Windows.Forms.ComboBox comboBox_Char1_Part1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
	}
}
