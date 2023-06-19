using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerForNumber
{
	public partial class StringForm : Form
	{
		public StringForm()
		{
			InitializeComponent();
		}

		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void CDownloadButton_Click(object sender, EventArgs e)
		{
			CStringTBox.Text = Program.cFNFramework.CFNToString();
		}

		private void CUploadButton_Click(object sender, EventArgs e)
		{
			try
			{
				Program.cFNFramework.SetByString(CStringTBox.Text);
				Program.numberView!.Refresh();
				Program.runForm!.Refresh();
			}
			catch (Exception exception)
			{
				MessageBox.Show(exception.Message);
				throw;
			}
		}
	}
}
