namespace MorseComposer.Presentation
{
	partial class DataWindow
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.DataViewer = new System.Windows.Forms.PropertyGrid();
			this.SuspendLayout();
			// 
			// DataViewer
			// 
			this.DataViewer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.DataViewer.Location = new System.Drawing.Point(0, 0);
			this.DataViewer.Name = "DataViewer";
			this.DataViewer.Size = new System.Drawing.Size(800, 450);
			this.DataViewer.TabIndex = 0;
			// 
			// DataWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.DataViewer);
			this.Name = "DataWindow";
			this.Text = "DataWindow";
			this.Load += new System.EventHandler(this.DataWindow_Load);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PropertyGrid DataViewer;
	}
}