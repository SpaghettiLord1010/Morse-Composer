﻿namespace MorseComposer.Presentation
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.MessageTranslate_TextBox = new System.Windows.Forms.TextBox();
            this.MessageEntry_TextBox = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkBox_AutoDelay = new System.Windows.Forms.CheckBox();
            this.showDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_play
            // 
            this.button_play.Enabled = false;
            this.button_play.Location = new System.Drawing.Point(124, 5);
            this.button_play.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button_play.Name = "button_play";
            this.button_play.Size = new System.Drawing.Size(136, 43);
            this.button_play.TabIndex = 20;
            this.button_play.Text = "PLAY";
            this.button_play.UseVisualStyleBackColor = true;
            this.button_play.Click += new System.EventHandler(this.PlayButton_OnClick);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 103);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1317, 794);
            this.flowLayoutPanel1.TabIndex = 28;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1323, 962);
            this.tableLayoutPanel1.TabIndex = 31;
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
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 5);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1315, 90);
            this.tableLayoutPanel2.TabIndex = 36;
            // 
            // SubmitButton
            // 
            this.SubmitButton.Location = new System.Drawing.Point(1199, 5);
            this.SubmitButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(112, 35);
            this.SubmitButton.TabIndex = 35;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // MessageTranslate_TextBox
            // 
            this.MessageTranslate_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageTranslate_TextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageTranslate_TextBox.Location = new System.Drawing.Point(4, 50);
            this.MessageTranslate_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MessageTranslate_TextBox.Name = "MessageTranslate_TextBox";
            this.MessageTranslate_TextBox.ReadOnly = true;
            this.MessageTranslate_TextBox.Size = new System.Drawing.Size(1187, 35);
            this.MessageTranslate_TextBox.TabIndex = 34;
            // 
            // MessageEntry_TextBox
            // 
            this.MessageEntry_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MessageEntry_TextBox.Location = new System.Drawing.Point(4, 5);
            this.MessageEntry_TextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MessageEntry_TextBox.Name = "MessageEntry_TextBox";
            this.MessageEntry_TextBox.Size = new System.Drawing.Size(1187, 26);
            this.MessageEntry_TextBox.TabIndex = 33;
            this.MessageEntry_TextBox.Text = "Hallelujah It Works!";
            // 
            // EditButton
            // 
            this.EditButton.Enabled = false;
            this.EditButton.Location = new System.Drawing.Point(1199, 50);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(112, 35);
            this.EditButton.TabIndex = 36;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.button1);
            this.flowLayoutPanel2.Controls.Add(this.button_play);
            this.flowLayoutPanel2.Controls.Add(this.menuStrip2);
            this.flowLayoutPanel2.Controls.Add(this.checkBox_AutoDelay);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(4, 905);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1308, 52);
            this.flowLayoutPanel2.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(4, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 21;
            this.button1.Text = "Execute";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ExecuteButton_OnClick);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem2,
            this.aboutToolStripMenuItem,
            this.dataWindowToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(264, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(270, 33);
            this.menuStrip2.TabIndex = 22;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // helpToolStripMenuItem2
            // 
            this.helpToolStripMenuItem2.Name = "helpToolStripMenuItem2";
            this.helpToolStripMenuItem2.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem2.Text = "Help";
            this.helpToolStripMenuItem2.Click += new System.EventHandler(this.helpToolStripMenuItem2_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(74, 29);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dataWindowToolStripMenuItem
            // 
            this.dataWindowToolStripMenuItem.Name = "dataWindowToolStripMenuItem";
            this.dataWindowToolStripMenuItem.Size = new System.Drawing.Size(127, 29);
            this.dataWindowToolStripMenuItem.Text = "DataWindow";
            this.dataWindowToolStripMenuItem.Click += new System.EventHandler(this.dataWindowToolStripMenuItem_Click);
            // 
            // checkBox_AutoDelay
            // 
            this.checkBox_AutoDelay.AutoSize = true;
            this.checkBox_AutoDelay.Location = new System.Drawing.Point(537, 3);
            this.checkBox_AutoDelay.Name = "checkBox_AutoDelay";
            this.checkBox_AutoDelay.Size = new System.Drawing.Size(527, 24);
            this.checkBox_AutoDelay.TabIndex = 23;
            this.checkBox_AutoDelay.Text = "Automatically assign the correct delays to fit the inernational standard.";
            this.checkBox_AutoDelay.UseVisualStyleBackColor = true;
            this.checkBox_AutoDelay.CheckedChanged += new System.EventHandler(this.checkBox_AutoDelay_CheckedChanged);
            // 
            // showDataToolStripMenuItem
            // 
            this.showDataToolStripMenuItem.Name = "showDataToolStripMenuItem";
            this.showDataToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.showDataToolStripMenuItem.Text = "Show Data Window...";
            this.showDataToolStripMenuItem.Click += new System.EventHandler(this.DataWindowMenuItem_OnClick);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.helpToolStripMenuItem.Text = "Help...";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.HelpWindowMenuItem_OnClick);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(186, 22);
            this.AboutMenuItem.Text = "About...";
            this.AboutMenuItem.Click += new System.EventHandler(this.AboutWindowMenuItem_OnClick);
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
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitMenuItem_OnClick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 962);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "MainWindow";
            this.Text = "Morse Composer";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_play;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.MenuStrip MainMenu;
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataWindowToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBox_AutoDelay;
    }
}

