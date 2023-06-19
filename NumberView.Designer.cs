namespace ComputerForNumber
{
	partial class NumberView
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
			ViewName = new TextBox();
			ViewNumber = new TextBox();
			AddButton = new Button();
			labelNumber = new Label();
			labelName = new Label();
			ViewList = new ControlList();
			SuspendLayout();
			// 
			// ViewName
			// 
			ViewName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			ViewName.Location = new Point(126, 805);
			ViewName.Margin = new Padding(4);
			ViewName.Name = "ViewName";
			ViewName.Size = new Size(962, 38);
			ViewName.TabIndex = 1;
			ViewName.Text = "Name";
			// 
			// ViewNumber
			// 
			ViewNumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			ViewNumber.Location = new Point(152, 759);
			ViewNumber.Margin = new Padding(4);
			ViewNumber.Name = "ViewNumber";
			ViewNumber.Size = new Size(936, 38);
			ViewNumber.TabIndex = 2;
			ViewNumber.Text = "Number";
			// 
			// AddButton
			// 
			AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			AddButton.Location = new Point(12, 854);
			AddButton.Margin = new Padding(4);
			AddButton.Name = "AddButton";
			AddButton.Size = new Size(1076, 46);
			AddButton.TabIndex = 3;
			AddButton.Text = "Add";
			AddButton.UseVisualStyleBackColor = true;
			AddButton.Click += AddButton_Click;
			// 
			// labelNumber
			// 
			labelNumber.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			labelNumber.AutoSize = true;
			labelNumber.Location = new Point(24, 765);
			labelNumber.Margin = new Padding(6, 0, 6, 0);
			labelNumber.Name = "labelNumber";
			labelNumber.Size = new Size(115, 31);
			labelNumber.TabIndex = 5;
			labelNumber.Text = "Number:";
			// 
			// labelName
			// 
			labelName.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			labelName.AutoSize = true;
			labelName.Location = new Point(24, 810);
			labelName.Margin = new Padding(6, 0, 6, 0);
			labelName.Name = "labelName";
			labelName.Size = new Size(89, 31);
			labelName.TabIndex = 6;
			labelName.Text = "Name:";
			// 
			// ViewList
			// 
			ViewList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			ViewList.AutoScroll = true;
			ViewList.BackColor = SystemColors.Control;
			ViewList.Location = new Point(12, 3);
			ViewList.Name = "ViewList";
			ViewList.Size = new Size(1076, 749);
			ViewList.TabIndex = 7;
			// 
			// NumberView
			// 
			AutoScaleDimensions = new SizeF(14F, 31F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1100, 913);
			Controls.Add(ViewList);
			Controls.Add(labelName);
			Controls.Add(labelNumber);
			Controls.Add(AddButton);
			Controls.Add(ViewNumber);
			Controls.Add(ViewName);
			Margin = new Padding(4);
			Name = "NumberView";
			Text = "NumberView";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion
		private TextBox ViewName;
		private TextBox ViewNumber;
		private Button AddButton;
		private Label labelNumber;
		private Label labelName;
		private ControlList ViewList;
	}
}