using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerForNumber
{
	public partial class RunForm : Form
	{
		public RunForm()
		{
			InitializeComponent();
			//RunThread = new Thread(this.RunFn);
			//RunThread.Start();
			Program.cFNFramework.CFN.PostValueChanged += ChageLabels;
			RunTimer.Tick += RunCFN;
		}

		private void RunCFN(object? sender, EventArgs e)
		{
			Program.computerForNumber!.ComputerForNumberFn();
			label1.TryInvoke(() => { label1.Text = RunCount.ToString(); });
		}

		int CV, C1V, C2V, V1V, V2V, Res;

		public void ChangeC()
		{
			CV = Program.cFNFramework.CFN[0];
			UICLabel.Text = "C:" + Program.cFNFramework.ShowNumber(CV);
		}

		public void ChangeC1()
		{
			C1V = Program.cFNFramework.CFN[CV];
			UIC1Label.Text = "C1:" + Program.cFNFramework.ShowNumber(C1V);
		}

		public void ChangeC2()
		{
			C2V = Program.cFNFramework.CFN[CV + 1];
			UIC2Label.Text = "C2:" + Program.cFNFramework.ShowNumber(C2V);
		}

		public void ChangeV1()
		{
			V1V = Program.cFNFramework.CFN[C1V];
			UIV1Label.Text = "V1:" + Program.cFNFramework.ShowNumber(V1V);
		}

		public void ChangeV2()
		{
			V2V = Program.cFNFramework.CFN[C2V];
			UIV2Label.Text = "V2:" + Program.cFNFramework.ShowNumber(V2V);
		}

		public void ChangeRes()
		{
			Res = V1V - V2V;
			UIResLabel.Text = "Res:" + Program.cFNFramework.ShowNumber(Res);
		}

		private void ChageLabels(int index)
		{

			//if (index == 0) { ChangeC(); ChangeC1(); ChangeC2(); ChangeV1(); ChangeV2(); ChangeRes(); }
			//else if (index == CV) { ChangeC1(); ChangeV1(); ChangeRes(); }
			//else if (index == CV + 1) { ChangeC2(); ChangeV2(); ChangeRes(); }
			//else if (index == C1V) { ChangeV1(); ChangeRes(); }
			//else if (index == C2V) { ChangeV2(); ChangeRes(); }
			this.Refresh();
		}

		public override void Refresh()
		{
			base.Refresh();
			{ ChangeC(); ChangeC1(); ChangeC2(); ChangeV1(); ChangeV2(); ChangeRes(); }
		}

		//public Thread? RunThread = null;
		public int RunCount = 0;
		//public double RunRate
		//{
		//	get => (double)BarRunRate.Value;
		//	set => BarRunRate.Value = (decimal)value;
		//}

		//public void RunFn()
		//{
		//	while (RunThread!.IsAlive && !this!.IsDisposed)
		//	{
		//		if (Program.computerForNumber![0] != 0)
		//		{
		//			if (RunCount == 0)
		//			{
		//				Time = DateTime.Now.Ticks;
		//			}
		//			else
		//				while ((DateTime.Now.Ticks - Time) > 0)
		//				{
		//					if (RunCount == 0) break;
		//					if (RunCount > -1) RunCount--;
		//					Time += 1000 / RunRate;
		//					if (!(RunThread!.IsAlive && !this!.IsDisposed)) return;
		//					Program.computerForNumber!.ComputerForNumberFn();
		//				}
		//		}
		//		else { RunCount = 0; }
		//		label1.TryInvoke(() => { label1.Text = RunCount.ToString(); });
		//		Thread.Yield();
		//	}
		//}

		private void CheckBoxCRun_CheckedChanged(object sender, EventArgs e)
		{
			if (CheckBoxCRun.Checked)
			{
				RunTimer.Start();
			}
			else
			{
				RunTimer.Stop();
			}
		}

		private void ButtonRunOnce_Click(object sender, EventArgs e)
		{
			//RunCount += 1;
			Program.computerForNumber!.ComputerForNumberFn();
		}


		protected override void OnClosing(CancelEventArgs e)
		{
			e.Cancel = true;
			this.Hide();
		}

		private void BarRunRate_ValueChanged(object sender, EventArgs e)
		{
			RunTimer.Interval = (int)BarRunRate.Value;
		}
	}
}
