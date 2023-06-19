namespace ComputerForNumber
{
	partial class View
	{
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			CloseButton = new Button();
			ValueText = new TextBox();
			splitContainer1 = new SplitContainer();
			labelIndex = new Label();
			NameText = new TextBox();
			((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
			splitContainer1.Panel1.SuspendLayout();
			splitContainer1.Panel2.SuspendLayout();
			splitContainer1.SuspendLayout();
			SuspendLayout();
			// 
			// CloseButton
			// 
			CloseButton.Location = new Point(818, 0);
			CloseButton.Margin = new Padding(6, 5, 6, 5);
			CloseButton.Name = "CloseButton";
			CloseButton.Size = new Size(44, 40);
			CloseButton.TabIndex = 0;
			CloseButton.Text = "D";
			CloseButton.UseVisualStyleBackColor = true;
			CloseButton.Click += CloseButton_Click;
			// 
			// ValueText
			// 
			ValueText.Location = new Point(596, 0);
			ValueText.Margin = new Padding(6, 5, 6, 5);
			ValueText.Name = "ValueText";
			ValueText.Size = new Size(206, 38);
			ValueText.TabIndex = 1;
			ValueText.KeyDown += ValueText_KeyDown;
			// 
			// splitContainer1
			// 
			splitContainer1.Location = new Point(0, 0);
			splitContainer1.Margin = new Padding(6, 5, 6, 5);
			splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			splitContainer1.Panel1.Controls.Add(labelIndex);
			// 
			// splitContainer1.Panel2
			// 
			splitContainer1.Panel2.Controls.Add(NameText);
			splitContainer1.Size = new Size(594, 40);
			splitContainer1.SplitterDistance = 268;
			splitContainer1.SplitterWidth = 8;
			splitContainer1.TabIndex = 2;
			// 
			// labelIndex
			// 
			labelIndex.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
			labelIndex.AutoSize = true;
			labelIndex.Location = new Point(6, 5);
			labelIndex.Margin = new Padding(6, 0, 6, 0);
			labelIndex.Name = "labelIndex";
			labelIndex.Size = new Size(77, 31);
			labelIndex.TabIndex = 0;
			labelIndex.Text = "Index";
			// 
			// NameText
			// 
			NameText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			NameText.Location = new Point(6, 0);
			NameText.Margin = new Padding(6, 5, 6, 5);
			NameText.Name = "NameText";
			NameText.Size = new Size(308, 38);
			NameText.TabIndex = 0;
			NameText.TextChanged += NameText_TextChanged;
			// 
			// View
			// 
			AutoScaleDimensions = new SizeF(14F, 31F);
			AutoScaleMode = AutoScaleMode.Font;
			Controls.Add(splitContainer1);
			Controls.Add(ValueText);
			Controls.Add(CloseButton);
			Margin = new Padding(4, 4, 4, 4);
			Name = "View";
			Size = new Size(868, 40);
			splitContainer1.Panel1.ResumeLayout(false);
			splitContainer1.Panel1.PerformLayout();
			splitContainer1.Panel2.ResumeLayout(false);
			splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
			splitContainer1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button CloseButton;
		private TextBox ValueText;
		private SplitContainer splitContainer1;
		private TextBox NameText;
		private Label labelIndex;
	}
}
