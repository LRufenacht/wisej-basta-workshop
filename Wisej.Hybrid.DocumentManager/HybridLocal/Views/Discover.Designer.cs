namespace HybridLocal.Views
{
	partial class Discover
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
			this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
			this.textBoxSearch = new Wisej.Web.TextBox();
			this.SuspendLayout();
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanel1.Location = new System.Drawing.Point(16, 128);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.Padding = new Wisej.Web.Padding(16);
			this.flexLayoutPanel1.Size = new System.Drawing.Size(368, 456);
			this.flexLayoutPanel1.TabIndex = 2;
			// 
			// textBoxSearch
			// 
			this.textBoxSearch.Dock = Wisej.Web.DockStyle.Top;
			this.textBoxSearch.LabelText = "Search Keywords...";
			this.textBoxSearch.Location = new System.Drawing.Point(16, 75);
			this.textBoxSearch.Name = "textBoxSearch";
			this.textBoxSearch.Size = new System.Drawing.Size(368, 53);
			this.textBoxSearch.TabIndex = 3;
			this.textBoxSearch.TextChanged += new System.EventHandler(this.textBoxSearch_TextChanged);
			// 
			// Discover
			// 
			this.Controls.Add(this.flexLayoutPanel1);
			this.Controls.Add(this.textBoxSearch);
			this.Name = "Discover";
			this.Title = "Home";
			this.Load += new System.EventHandler(this.Home_Load);
			this.Controls.SetChildIndex(this.textBoxSearch, 0);
			this.Controls.SetChildIndex(this.flexLayoutPanel1, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.FlexLayoutPanel flexLayoutPanel1;
		private Wisej.Web.TextBox textBoxSearch;
	}
}
