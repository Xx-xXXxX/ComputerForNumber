using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static ComputerForNumber.Program;
namespace ComputerForNumber
{
	public partial class Form1 : Form
	{
		protected override void OnClosed(EventArgs e)
		{

		}
		public Form1()
		{
			InitializeComponent();

			numberView = new NumberView();
			numberView.Show();
			computerForNumber!.PostValueChanged += ChangeView;
			cFNFramework.OnAdd += RefreshRequired;
			cFNFramework.OnRemove += RefreshRequired;
			cFNFramework.OnNameChanged += RefreshRequired;
			runForm = new();
			runForm.Show();
			cFNFramework.AddView(0, "C");

			cFNFramework.AddView(1, "P");

			stringForm = new();
			stringForm.Show();

		}

		public static void RefreshRequired(CFNFramework.CFNFrameworkView obj)
		{
			foreach (var i in cFNFramework.CFN)
			{
				if (cFNFramework.CFN[i] == obj.Index)
					if (numberView!.IndexToView.TryGetValue(i.SIToUSI(Program.BitLength), out var views))
						foreach (var j in views) j.Refresh();
			}
		}


		private void ChangeView(int obj)
		{
			if (numberView!.IndexToView.ContainsKey(obj.SIToUSI(Program.BitLength)))
			{
				int v = computerForNumber![obj];
				foreach (var i in numberView!.IndexToView[obj.SIToUSI(Program.BitLength)])
				{
					//i.Value = v;
					//i.ResetValue();
					i.TryInvoke(() => i.Refresh());
				}
			}
		}

		private void 数字ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			numberView!.Show();
		}

		private void 运行ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			runForm!.Show();
		}

		private void 字符ToolStripMenuItem_Click(object sender, EventArgs e)
		{
			stringForm!.Show();
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}
	}
}
