using System;
using System.Windows.Forms;

namespace MorseComposer.Presentation
{
	public partial class DataWindow : Form
	{
		public DataWindow()
		{
			InitializeComponent();
		}


		private void DataWindow_Load(object sender, EventArgs e)
		{
			DataViewer.SelectedObject = Program.Data;
		}


	}
}
