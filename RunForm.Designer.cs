namespace ComputerForNumber
{
	partial class RunForm
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
			components = new System.ComponentModel.Container();
			ButtonRunOnce = new Button();
			CheckBoxCRun = new CheckBox();
			BarRunRate = new NumericUpDown();
			label1 = new Label();
			UICLabel = new Label();
			UIC1Label = new Label();
			UIC2Label = new Label();
			UIV1Label = new Label();
			UIV2Label = new Label();
			UIResLabel = new Label();
			RunTimer = new System.Windows.Forms.Timer(components);
			((System.ComponentModel.ISupportInitialize)BarRunRate).BeginInit();
			SuspendLayout();
			// 
			// ButtonRunOnce
			// 
			ButtonRunOnce.Location = new Point(12, 12);
			ButtonRunOnce.Name = "ButtonRunOnce";
			ButtonRunOnce.Size = new Size(150, 46);
			ButtonRunOnce.TabIndex = 0;
			ButtonRunOnce.Text = "运行一次";
			ButtonRunOnce.UseVisualStyleBackColor = true;
			ButtonRunOnce.Click += ButtonRunOnce_Click;
			// 
			// CheckBoxCRun
			// 
			CheckBoxCRun.AutoSize = true;
			CheckBoxCRun.Location = new Point(168, 19);
			CheckBoxCRun.Name = "CheckBoxCRun";
			CheckBoxCRun.Size = new Size(142, 35);
			CheckBoxCRun.TabIndex = 1;
			CheckBoxCRun.Text = "持续运行";
			CheckBoxCRun.UseVisualStyleBackColor = true;
			CheckBoxCRun.CheckedChanged += CheckBoxCRun_CheckedChanged;
			// 
			// BarRunRate
			// 
			BarRunRate.Location = new Point(316, 16);
			BarRunRate.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
			BarRunRate.Name = "BarRunRate";
			BarRunRate.Size = new Size(240, 38);
			BarRunRate.TabIndex = 2;
			BarRunRate.Value = new decimal(new int[] { 100, 0, 0, 0 });
			BarRunRate.ValueChanged += BarRunRate_ValueChanged;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 61);
			label1.Name = "label1";
			label1.Size = new Size(82, 31);
			label1.TabIndex = 3;
			label1.Text = "label1";
			// 
			// UICLabel
			// 
			UICLabel.AutoSize = true;
			UICLabel.Location = new Point(12, 92);
			UICLabel.Name = "UICLabel";
			UICLabel.Size = new Size(36, 31);
			UICLabel.TabIndex = 4;
			UICLabel.Text = "C:";
			// 
			// UIC1Label
			// 
			UIC1Label.AutoSize = true;
			UIC1Label.Location = new Point(12, 133);
			UIC1Label.Name = "UIC1Label";
			UIC1Label.Size = new Size(50, 31);
			UIC1Label.TabIndex = 5;
			UIC1Label.Text = "C1:";
			// 
			// UIC2Label
			// 
			UIC2Label.AutoSize = true;
			UIC2Label.Location = new Point(407, 133);
			UIC2Label.Name = "UIC2Label";
			UIC2Label.Size = new Size(50, 31);
			UIC2Label.TabIndex = 6;
			UIC2Label.Text = "C2:";
			// 
			// UIV1Label
			// 
			UIV1Label.AutoSize = true;
			UIV1Label.Location = new Point(12, 193);
			UIV1Label.Name = "UIV1Label";
			UIV1Label.Size = new Size(50, 31);
			UIV1Label.TabIndex = 7;
			UIV1Label.Text = "V1:";
			// 
			// UIV2Label
			// 
			UIV2Label.AutoSize = true;
			UIV2Label.Location = new Point(407, 193);
			UIV2Label.Name = "UIV2Label";
			UIV2Label.Size = new Size(50, 31);
			UIV2Label.TabIndex = 8;
			UIV2Label.Text = "V2:";
			// 
			// UIResLabel
			// 
			UIResLabel.AutoSize = true;
			UIResLabel.Location = new Point(407, 253);
			UIResLabel.Name = "UIResLabel";
			UIResLabel.Size = new Size(61, 31);
			UIResLabel.TabIndex = 9;
			UIResLabel.Text = "Res:";
			// 
			// RunForm
			// 
			AutoScaleDimensions = new SizeF(14F, 31F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(786, 651);
			Controls.Add(UIResLabel);
			Controls.Add(UIV2Label);
			Controls.Add(UIV1Label);
			Controls.Add(UIC2Label);
			Controls.Add(UIC1Label);
			Controls.Add(UICLabel);
			Controls.Add(label1);
			Controls.Add(BarRunRate);
			Controls.Add(CheckBoxCRun);
			Controls.Add(ButtonRunOnce);
			Name = "RunForm";
			Text = "RunForm";
			((System.ComponentModel.ISupportInitialize)BarRunRate).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button ButtonRunOnce;
		private CheckBox CheckBoxCRun;
		public NumericUpDown BarRunRate;
		private Label label1;
		private Label UICLabel;
		private Label UIC1Label;
		private Label UIC2Label;
		private Label UIV1Label;
		private Label UIV2Label;
		private Label UIResLabel;
		private System.Windows.Forms.Timer RunTimer;
	}
}