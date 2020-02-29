using System;
using System.Runtime;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

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
            this.comboBox_Char1_Part1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_DelayChar1Part1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numUpDown_DelayChar1Part1
            // 
            this.numUpDown_DelayChar1Part1.Location = new System.Drawing.Point(117, 31);
            this.numUpDown_DelayChar1Part1.Margin = new System.Windows.Forms.Padding(6);
            this.numUpDown_DelayChar1Part1.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numUpDown_DelayChar1Part1.Name = "numUpDown_DelayChar1Part1";
            this.numUpDown_DelayChar1Part1.Size = new System.Drawing.Size(141, 30);
            this.numUpDown_DelayChar1Part1.TabIndex = 64;
            this.numUpDown_DelayChar1Part1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.numUpDown_DelayChar1Part1.ThousandsSeparator = true;
            // 
            // comboBox_Char1_Part1
            // 
            this.comboBox_Char1_Part1.DisplayMember = "NoteName";
            this.comboBox_Char1_Part1.FormattingEnabled = true;
            this.comboBox_Char1_Part1.Location = new System.Drawing.Point(6, 31);
            this.comboBox_Char1_Part1.Margin = new System.Windows.Forms.Padding(6);
            this.comboBox_Char1_Part1.Name = "comboBox_Char1_Part1";
            this.comboBox_Char1_Part1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox_Char1_Part1.Size = new System.Drawing.Size(99, 33);
            this.comboBox_Char1_Part1.TabIndex = 62;
            this.comboBox_Char1_Part1.ValueMember = "Frequency";
            this.comboBox_Char1_Part1.SelectedIndexChanged += new System.EventHandler(this.comboBox_Char1_Part1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 25);
            this.label2.TabIndex = 66;
            this.label2.Text = "Delay (Beats)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 65;
            this.label1.Text = "Tone";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.numUpDown_DelayChar1Part1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_Char1_Part1, 0, 1);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(11, 70);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(264, 70);
            this.tableLayoutPanel1.TabIndex = 67;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 0);
            this.groupBox1.Size = new System.Drawing.Size(287, 188);
            this.groupBox1.TabIndex = 68;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Symbol";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // MorseSymbolEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "MorseSymbolEntry";
            this.Size = new System.Drawing.Size(299, 200);
            ((System.ComponentModel.ISupportInitialize)(this.numUpDown_DelayChar1Part1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.NumericUpDown numUpDown_DelayChar1Part1;
		private System.Windows.Forms.ComboBox comboBox_Char1_Part1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}
