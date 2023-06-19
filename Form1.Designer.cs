namespace ComputerForNumber
{
	partial class Form1
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
			menuStrip1 = new MenuStrip();
			视图ToolStripMenuItem1 = new ToolStripMenuItem();
			数字ToolStripMenuItem1 = new ToolStripMenuItem();
			运行ToolStripMenuItem = new ToolStripMenuItem();
			字符ToolStripMenuItem = new ToolStripMenuItem();
			openFileDialog1 = new OpenFileDialog();
			saveFileDialog1 = new SaveFileDialog();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.ImageScalingSize = new Size(32, 32);
			menuStrip1.Items.AddRange(new ToolStripItem[] { 视图ToolStripMenuItem1 });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(424, 42);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// 视图ToolStripMenuItem1
			// 
			视图ToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { 数字ToolStripMenuItem1, 运行ToolStripMenuItem, 字符ToolStripMenuItem });
			视图ToolStripMenuItem1.Name = "视图ToolStripMenuItem1";
			视图ToolStripMenuItem1.Size = new Size(82, 38);
			视图ToolStripMenuItem1.Text = "视图";
			// 
			// 数字ToolStripMenuItem1
			// 
			数字ToolStripMenuItem1.Name = "数字ToolStripMenuItem1";
			数字ToolStripMenuItem1.Size = new Size(359, 44);
			数字ToolStripMenuItem1.Text = "NumberView";
			数字ToolStripMenuItem1.Click += 数字ToolStripMenuItem1_Click;
			// 
			// 运行ToolStripMenuItem
			// 
			运行ToolStripMenuItem.Name = "运行ToolStripMenuItem";
			运行ToolStripMenuItem.Size = new Size(359, 44);
			运行ToolStripMenuItem.Text = "Run";
			运行ToolStripMenuItem.Click += 运行ToolStripMenuItem_Click;
			// 
			// 字符ToolStripMenuItem
			// 
			字符ToolStripMenuItem.Name = "字符ToolStripMenuItem";
			字符ToolStripMenuItem.Size = new Size(359, 44);
			字符ToolStripMenuItem.Text = "String";
			字符ToolStripMenuItem.Click += 字符ToolStripMenuItem_Click;
			// 
			// openFileDialog1
			// 
			openFileDialog1.FileName = "openFileDialog1";
			openFileDialog1.FileOk += openFileDialog1_FileOk;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(14F, 31F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(424, 72);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Margin = new Padding(4);
			Name = "Form1";
			Text = "Form1";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private MenuStrip menuStrip1;
		private ToolStripMenuItem 视图ToolStripMenuItem1;
		private ToolStripMenuItem 数字ToolStripMenuItem1;
		private ToolStripMenuItem 运行ToolStripMenuItem;
		private OpenFileDialog openFileDialog1;
		private SaveFileDialog saveFileDialog1;
		private ToolStripMenuItem 字符ToolStripMenuItem;
	}
}