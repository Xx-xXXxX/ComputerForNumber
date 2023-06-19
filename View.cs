using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerForNumber
{
	public partial class View : UserControl
	{
		public override string ToString()
		{
			return "N";
		}
		public readonly CFNFramework.CFNFrameworkView view;
		public View(CFNFramework.CFNFrameworkView view)
		{

			this.view = view;
			InitializeComponent();
			Refresh();
		}

		public int Index => view.Index;
		public string NumName { get => view.NumName; set => view.NumName = value; }
		public override void Refresh()
		{
			ValueText.Text = Program.cFNFramework.ShowNumber(Program.computerForNumber[Index]);
			NameText.Text = view.NumName;
			labelIndex.Text = view.Index.ToString();
			base.Refresh();
		}
		public int Value => view.Value;

		private void CloseButton_Click(object sender, EventArgs e)
		{
			//Program.numberView!.Remove(this);
			Program.cFNFramework.RemoveView(this.view);
		}

		private void NameText_TextChanged(object sender, EventArgs e)
		{
			NumName = NameText.Text;
			if (Value != 0 && Program.numberView!.IndexToView.TryGetValue(Value.SIToUSI(Program.BitLength), out var views))
				foreach (var item in views)
				{
					item.Refresh();
				}
		}
		private void ValueText_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{

				if (int.TryParse(ValueText.Text, out int v))
				{
					Program.computerForNumber![Index] = v;// Value = v;

				}
				else
				{
					MessageBox.Show("Not a number!");
					ValueText.Text = "0";
				}
			}
		}
	}
}
