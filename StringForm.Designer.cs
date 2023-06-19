namespace ComputerForNumber
{
	partial class StringForm
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
			CStringTBox = new TextBox();
			CDownloadButton = new Button();
			CUploadButton = new Button();
			SuspendLayout();
			// 
			// CStringTBox
			// 
			CStringTBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			CStringTBox.Location = new Point(12, 12);
			CStringTBox.Multiline = true;
			CStringTBox.Name = "CStringTBox";
			CStringTBox.ScrollBars = ScrollBars.Both;
			CStringTBox.Size = new Size(1377, 723);
			CStringTBox.TabIndex = 0;
			// 
			// CDownloadButton
			// 
			CDownloadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			CDownloadButton.Location = new Point(683, 741);
			CDownloadButton.Name = "CDownloadButton";
			CDownloadButton.Size = new Size(706, 46);
			CDownloadButton.TabIndex = 1;
			CDownloadButton.Text = "下载";
			CDownloadButton.UseVisualStyleBackColor = true;
			CDownloadButton.Click += CDownloadButton_Click;
			// 
			// CUploadButton
			// 
			CUploadButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			CUploadButton.Location = new Point(12, 741);
			CUploadButton.Name = "CUploadButton";
			CUploadButton.Size = new Size(665, 46);
			CUploadButton.TabIndex = 2;
			CUploadButton.Text = "上载";
			CUploadButton.UseVisualStyleBackColor = true;
			CUploadButton.Click += CUploadButton_Click;
			// 
			// StringForm
			// 
			AutoScaleDimensions = new SizeF(14F, 31F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1401, 799);
			Controls.Add(CUploadButton);
			Controls.Add(CDownloadButton);
			Controls.Add(CStringTBox);
			Name = "StringForm";
			Text = "StringForm";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox CStringTBox;
		private Button CDownloadButton;
		private Button CUploadButton;
	}
}