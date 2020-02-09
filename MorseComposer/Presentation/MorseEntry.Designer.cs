namespace MorseComposer.Presentation
{
    partial class MorseEntry
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

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
			this.Identifier_Label = new System.Windows.Forms.Label();
			this.Character_Label = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.Morse_Label = new System.Windows.Forms.Label();
			this.SymbolPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// Identifier_Label
			// 
			this.Identifier_Label.AutoSize = true;
			this.Identifier_Label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Identifier_Label.Location = new System.Drawing.Point(98, 54);
			this.Identifier_Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.Identifier_Label.Name = "Identifier_Label";
			this.Identifier_Label.Size = new System.Drawing.Size(897, 68);
			this.Identifier_Label.TabIndex = 41;
			this.Identifier_Label.Text = "ID";
			// 
			// Character_Label
			// 
			this.Character_Label.AutoSize = true;
			this.Character_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Character_Label.Location = new System.Drawing.Point(3, 0);
			this.Character_Label.Name = "Character_Label";
			this.Character_Label.Size = new System.Drawing.Size(67, 24);
			this.Character_Label.TabIndex = 64;
			this.Character_Label.Text = "CHAR";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label2.Location = new System.Drawing.Point(3, 54);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(90, 68);
			this.label2.TabIndex = 65;
			this.label2.Text = "Identifier:";
			// 
			// Morse_Label
			// 
			this.Morse_Label.AutoSize = true;
			this.Morse_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Morse_Label.Location = new System.Drawing.Point(3, 24);
			this.Morse_Label.Name = "Morse_Label";
			this.Morse_Label.Size = new System.Drawing.Size(84, 24);
			this.Morse_Label.TabIndex = 66;
			this.Morse_Label.Text = "MORSE";
			// 
			// SymbolPanel
			// 
			this.SymbolPanel.AutoSize = true;
			this.SymbolPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.SymbolPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SymbolPanel.Location = new System.Drawing.Point(99, 3);
			this.SymbolPanel.Name = "SymbolPanel";
			this.SymbolPanel.Size = new System.Drawing.Size(895, 48);
			this.SymbolPanel.TabIndex = 67;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.SymbolPanel, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.Identifier_Label, 1, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(997, 122);
			this.tableLayoutPanel1.TabIndex = 68;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel2.ColumnCount = 1;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.Character_Label, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.Morse_Label, 0, 1);
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(90, 48);
			this.tableLayoutPanel2.TabIndex = 69;
			// 
			// MorseEntry
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MorseEntry";
			this.Size = new System.Drawing.Size(1003, 128);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Identifier_Label;
		private System.Windows.Forms.Label Character_Label;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label Morse_Label;
		private System.Windows.Forms.FlowLayoutPanel SymbolPanel;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
	}
}
