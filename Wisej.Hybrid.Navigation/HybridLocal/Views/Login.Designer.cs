namespace HybridLocal.Views
{
	partial class Login
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
			this.button1 = new Wisej.Web.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Anchor = Wisej.Web.AnchorStyles.None;
			this.button1.Location = new System.Drawing.Point(99, 282);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(202, 37);
			this.button1.TabIndex = 2;
			this.button1.Text = "Login";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Login
			// 
			this.Controls.Add(this.button1);
			this.Name = "Login";
			this.Title = "Login";
			this.Controls.SetChildIndex(this.button1, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Button button1;
	}
}
