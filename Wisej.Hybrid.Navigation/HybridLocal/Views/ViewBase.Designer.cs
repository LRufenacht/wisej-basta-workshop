namespace HybridLocal.Views
{
	partial class ViewBase
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
			this.labelTitle = new Wisej.Web.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.labelTitle.AutoSize = true;
			this.labelTitle.Dock = Wisej.Web.DockStyle.Top;
			this.labelTitle.Font = new System.Drawing.Font("windowTitle", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
			this.labelTitle.Location = new System.Drawing.Point(16, 16);
			this.labelTitle.Name = "label1";
			this.labelTitle.Size = new System.Drawing.Size(368, 43);
			this.labelTitle.TabIndex = 1;
			this.labelTitle.Text = "View Title";
			// 
			// ViewBase
			// 
			this.Controls.Add(this.labelTitle);
			this.Name = "ViewBase";
			this.Padding = new Wisej.Web.Padding(16);
			this.Size = new System.Drawing.Size(400, 600);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Label labelTitle;
	}
}
