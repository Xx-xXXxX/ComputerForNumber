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

	public partial class ControlList : UserControl
	{
		public void Clear() {
			Controls.Clear();
			Controls.Add(panel1);
			ControlstHeight = 0;
		}
		protected override void OnResize(EventArgs e)
		{
			base.OnResize(e);
			//this.Location = new Point(0, 0);
			//panel.Location = new Point(20, 20);
			//panel.Size = new Size(this.Size.Width - 20, this.Size.Height - 20);
			//vScrollBar1.Minimum = 0;
			//vScrollBar1.Maximum = ControlstHeight;

			//vScrollBar1 = Math.Min(ControlstHeight,this.Height);
			int height = 0;
			foreach (var i in this.Controls.Cast<Control>())
			{
				if (i != panel1)
				{
					i.Top = height;
					height += i.Height;
				}
			}
			panel1.Location = new Point(0, 0);
			panel1.Size = new Size(1, height);
		}
		public ControlList()
		{
			InitializeComponent();
			this.components = new System.ComponentModel.Container();
		}
		public Control this[int i]
		{
			get => Controls[i];
		}
		public int ControlstHeight { get; private set; }
		public int Count => this.Controls.Count;
		public int Add(Control control)
		{
			this.components.Add(control);
			this.Controls.Add(control);
			control.Parent = this;
			control.Top = ControlstHeight;
			ControlstHeight += control.Height;
			this.Refresh();
			return Count;
		}
		public Control? Remove(Control control) => Remove(Controls.IndexOf(control));
		public Control? Remove(int i)
		{
			var t = this.Controls[i];
			if (t != null)
			{
				int h = t.Height;
				for (int j = i; j < Controls.Count; ++j)
				{
					Controls[j].Top -= h;
				}
				this.Controls.RemoveAt(i);
				this.components.Remove(t);
				t.Parent = null;
				ControlstHeight -= h;
			}
			return t;
		}

	}


}
