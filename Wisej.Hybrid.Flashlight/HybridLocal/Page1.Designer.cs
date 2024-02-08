namespace HybridLocal
{
	partial class Page1
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

		#region Wisej Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.buttonOn = new Wisej.Web.Button();
			this.buttonOff = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// buttonOn
			// 
			this.buttonOn.Location = new System.Drawing.Point(57, 42);
			this.buttonOn.Name = "buttonOn";
			this.buttonOn.Size = new System.Drawing.Size(230, 81);
			this.buttonOn.TabIndex = 0;
			this.buttonOn.Text = "Turn Flashlight On";
			this.buttonOn.Click += new System.EventHandler(this.buttonOn_Click);
			// 
			// buttonOff
			// 
			this.buttonOff.Location = new System.Drawing.Point(57, 179);
			this.buttonOff.Name = "buttonOff";
			this.buttonOff.Size = new System.Drawing.Size(230, 81);
			this.buttonOff.TabIndex = 1;
			this.buttonOff.Text = "Turn Flashlight Off";
			this.buttonOff.Click += new System.EventHandler(this.buttonOff_Click);
			// 
			// Page1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
			this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
			this.Controls.Add(this.buttonOff);
			this.Controls.Add(this.buttonOn);
			this.Name = "Page1";
			this.Size = new System.Drawing.Size(1814, 1212);
			this.Text = "Page1";
			this.ResumeLayout(false);

		}

		#endregion

		private Wisej.Web.Button buttonOn;
		private Wisej.Web.Button buttonOff;
	}
}

