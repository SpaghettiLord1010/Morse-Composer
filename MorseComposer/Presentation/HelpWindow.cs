using System.Diagnostics;
using System.Windows.Forms;

namespace MorseComposer.Presentation
{
	public partial class HelpWindow : Form
	{
		public HelpWindow()
		{
			InitializeComponent();
		}

		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(linkLabel1.Text);
		}

		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start(linkLabel2.Text);
		}


	}
}
