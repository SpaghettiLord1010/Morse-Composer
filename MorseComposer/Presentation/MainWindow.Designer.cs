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
			this.frequenciesBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.frequencySheet1DataSet = new MorseComposer.FrequencySheet1DataSet();
			this.frequenciesTableAdapter = new MorseComposer.FrequencySheet1DataSetTableAdapters.FrequenciesTableAdapter();
			this.button_play = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.butt_addChar = new System.Windows.Forms.Button();
			this.butt_remChar = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			((System.ComponentModel.ISupportInitialize)(this.frequenciesBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.frequencySheet1DataSet)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
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
			// button_play
			// 
			this.button_play.Location = new System.Drawing.Point(3, 3);
			this.button_play.Name = "button_play";
			this.button_play.Size = new System.Drawing.Size(91, 28);
			this.button_play.TabIndex = 20;
			this.button_play.Text = "PLAY";
			this.button_play.UseVisualStyleBackColor = true;
			this.button_play.Click += new System.EventHandler(this.button_play_Click);
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.AutoScroll = true;
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 2);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(426, 239);
			this.flowLayoutPanel1.TabIndex = 28;
			// 
			// butt_addChar
			// 
			this.butt_addChar.Location = new System.Drawing.Point(99, 2);
			this.butt_addChar.Margin = new System.Windows.Forms.Padding(2);
			this.butt_addChar.Name = "butt_addChar";
			this.butt_addChar.Size = new System.Drawing.Size(101, 28);
			this.butt_addChar.TabIndex = 29;
			this.butt_addChar.Text = "ADD CHAR";
			this.butt_addChar.UseVisualStyleBackColor = true;
			this.butt_addChar.Click += new System.EventHandler(this.butt_addChar_Click);
			// 
			// butt_remChar
			// 
			this.butt_remChar.Location = new System.Drawing.Point(204, 2);
			this.butt_remChar.Margin = new System.Windows.Forms.Padding(2);
			this.butt_remChar.Name = "butt_remChar";
			this.butt_remChar.Size = new System.Drawing.Size(101, 28);
			this.butt_remChar.TabIndex = 30;
			this.butt_remChar.Text = "REMOVE CHAR";
			this.butt_remChar.UseVisualStyleBackColor = true;
			this.butt_remChar.Click += new System.EventHandler(this.butt_remChar_Click);
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 1);
			this.tableLayoutPanel1.Location = new System.Drawing.Point(102, 145);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(430, 283);
			this.tableLayoutPanel1.TabIndex = 31;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel2.Controls.Add(this.button_play);
			this.flowLayoutPanel2.Controls.Add(this.butt_addChar);
			this.flowLayoutPanel2.Controls.Add(this.butt_remChar);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 246);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(307, 34);
			this.flowLayoutPanel2.TabIndex = 29;
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.AboutMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(732, 24);
			this.menuStrip1.TabIndex = 32;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDataToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			// 
			// AboutMenuItem
			// 
			this.AboutMenuItem.Name = "AboutMenuItem";
			this.AboutMenuItem.Size = new System.Drawing.Size(61, 20);
			this.AboutMenuItem.Text = "&About...";
			this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_OnClick);
			// 
			// showDataToolStripMenuItem
			// 
			this.showDataToolStripMenuItem.Name = "showDataToolStripMenuItem";
			this.showDataToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.showDataToolStripMenuItem.Text = "Show Data Window...";
			this.showDataToolStripMenuItem.Click += new System.EventHandler(this.DataWindowMenuItem_OnClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(732, 550);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainWindow";
			this.Text = "Morse Composer";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.frequenciesBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.frequencySheet1DataSet)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private FrequencySheet1DataSet frequencySheet1DataSet;
        private System.Windows.Forms.BindingSource frequenciesBindingSource;
        private FrequencySheet1DataSetTableAdapters.FrequenciesTableAdapter frequenciesTableAdapter;
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button butt_addChar;
        private System.Windows.Forms.Button butt_remChar;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showDataToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
	}
}

