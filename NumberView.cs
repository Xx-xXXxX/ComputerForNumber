using System;
using System.Collections;
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
	public partial class NumberView : Form
	{
		//public ProxyPanelAsControlsList ViewList;
		public NumberView()
		{
			InitializeComponent();
			Program.cFNFramework.OnAdd += AddView;
			Program.cFNFramework.OnRemove += RemoveView;
			Program.computerForNumber.OnReset += ComputerForNumber_OnReset;
			//ViewList = new(ViewsPanel);
		}

		private void ComputerForNumber_OnReset()
		{
			//throw new NotImplementedException();
			ViewList.Clear();
			IndexToView.Clear();
			NameToView.Clear();
		}

		protected override void OnClosing(CancelEventArgs e)
		{

			e.Cancel = true;
			this.Hide();
		}

		private void AddButton_Click(object sender, EventArgs e)
		{
			//AddView(int.Parse(ViewNumber.Text), ViewName.Text);
			Program.cFNFramework.AddView(int.Parse(ViewNumber.Text), ViewName.Text);
		}
		public void AddView(CFNFramework.CFNFrameworkView view)
		{
			int index = view.Index;
			string name = view.NumName;
			if (NameToView.ContainsKey(name)) throw new Exception("view.NumName已存在");
			var NewView = new View(view);
			NewView.Anchor = AnchorStyles.Left | AnchorStyles.Right;
			ViewList.Add(NewView);
			if (!IndexToView.TryGetValue(index.SIToUSI(Program.BitLength), out var views)) IndexToView.Add(index.SIToUSI(Program.BitLength), views = new());
			views.Add(NewView);
			NameToView.Add(name, NewView);
			return;
		}
		public void RemoveView(CFNFramework.CFNFrameworkView cfnview)
		{
			var view = NameToView[cfnview.NumName];
			if (!NameToView.ContainsKey(view.NumName)) throw new Exception("view.NumName不存在");
			//Program.cFNFramework.Remove(view.view);
			ViewList.Remove(view);
			IndexToView[view.Index.SIToUSI(Program.BitLength)].Remove(view);
			NameToView.Remove(view.NumName);
			Refresh();
			return;
		}
		public readonly SortedDictionary<uint, HashSet<View>> IndexToView = new();
		public readonly SortedDictionary<string, View> NameToView = new SortedDictionary<string, View>();
	}
}
