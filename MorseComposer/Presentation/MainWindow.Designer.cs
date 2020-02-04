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
			this.button_play = new System.Windows.Forms.Button();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.butt_addChar = new System.Windows.Forms.Button();
			this.butt_remChar = new System.Windows.Forms.Button();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.MainMenuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.showDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.MessageEntry_TextBox = new System.Windows.Forms.TextBox();
			this.MessageTranslate_TextBox = new System.Windows.Forms.TextBox();
			this.SubmitButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.EditButton = new System.Windows.Forms.Button();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.MainMenuStrip.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			this.SuspendLayout();
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
			this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 66);
			this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(878, 418);
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
			this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(882, 526);
			this.tableLayoutPanel1.TabIndex = 31;
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.AutoSize = true;
			this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.flowLayoutPanel2.Controls.Add(this.button_play);
			this.flowLayoutPanel2.Controls.Add(this.butt_addChar);
			this.flowLayoutPanel2.Controls.Add(this.butt_remChar);
			this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 489);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(307, 34);
			this.flowLayoutPanel2.TabIndex = 29;
			// 
			// MainMenuStrip
			// 
			this.MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
			this.MainMenuStrip.Location = new System.Drawing.Point(0, 0);
			this.MainMenuStrip.Name = "MainMenuStrip";
			this.MainMenuStrip.Size = new System.Drawing.Size(882, 24);
			this.MainMenuStrip.TabIndex = 32;
			this.MainMenuStrip.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showDataToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.AboutMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "&File";
			// 
			// showDataToolStripMenuItem
			// 
			this.showDataToolStripMenuItem.Name = "showDataToolStripMenuItem";
			this.showDataToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.showDataToolStripMenuItem.Text = "Show Data Window...";
			this.showDataToolStripMenuItem.Click += new System.EventHandler(this.DataWindowMenuItem_OnClick);
			// 
			// AboutMenuItem
			// 
			this.AboutMenuItem.Name = "AboutMenuItem";
			this.AboutMenuItem.Size = new System.Drawing.Size(186, 22);
			this.AboutMenuItem.Text = "About...";
			this.AboutMenuItem.Click += new System.EventHandler(this.AboutMenuItem_OnClick);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(183, 6);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.exitToolStripMenuItem.Text = "E&xit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// MessageEntry_TextBox
			// 
			this.MessageEntry_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MessageEntry_TextBox.Location = new System.Drawing.Point(3, 3);
			this.MessageEntry_TextBox.Name = "MessageEntry_TextBox";
			this.MessageEntry_TextBox.Size = new System.Drawing.Size(789, 20);
			this.MessageEntry_TextBox.TabIndex = 33;
			this.MessageEntry_TextBox.Text = "Hello World!";
			// 
			// MessageTranslate_TextBox
			// 
			this.MessageTranslate_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.MessageTranslate_TextBox.Location = new System.Drawing.Point(3, 32);
			this.MessageTranslate_TextBox.Name = "MessageTranslate_TextBox";
			this.MessageTranslate_TextBox.ReadOnly = true;
			this.MessageTranslate_TextBox.Size = new System.Drawing.Size(789, 20);
			this.MessageTranslate_TextBox.TabIndex = 34;
			// 
			// SubmitButton
			// 
			this.SubmitButton.Location = new System.Drawing.Point(798, 3);
			this.SubmitButton.Name = "SubmitButton";
			this.SubmitButton.Size = new System.Drawing.Size(75, 23);
			this.SubmitButton.TabIndex = 35;
			this.SubmitButton.Text = "Submit";
			this.SubmitButton.UseVisualStyleBackColor = true;
			this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoSize = true;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel2.Controls.Add(this.SubmitButton, 1, 0);
			this.tableLayoutPanel2.Controls.Add(this.MessageTranslate_TextBox, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.MessageEntry_TextBox, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.EditButton, 1, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel2.Size = new System.Drawing.Size(876, 58);
			this.tableLayoutPanel2.TabIndex = 36;
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
			this.helpToolStripMenuItem.Text = "Help...";
			this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
			// 
			// EditButton
			// 
			this.EditButton.Enabled = false;
			this.EditButton.Location = new System.Drawing.Point(798, 32);
			this.EditButton.Name = "EditButton";
			this.EditButton.Size = new System.Drawing.Size(75, 23);
			this.EditButton.TabIndex = 36;
			this.EditButton.Text = "Edit";
			this.EditButton.UseVisualStyleBackColor = true;
			this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(882, 550);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.MainMenuStrip);
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "MainWindow";
			this.Text = "Morse Composer";
			this.Load += new System.EventHandler(this.OnLoad);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.MainMenuStrip.ResumeLayout(false);
			this.MainMenuStrip.PerformLayout();
			this.tableLayoutPanel2.ResumeLayout(false);
			this.tableLayoutPanel2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button butt_addChar;
        private System.Windows.Forms.Button butt_remChar;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.MenuStrip MainMenuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem showDataToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
		private System.Windows.Forms.TextBox MessageEntry_TextBox;
		private System.Windows.Forms.TextBox MessageTranslate_TextBox;
		private System.Windows.Forms.Button SubmitButton;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.Button EditButton;
	}
}

