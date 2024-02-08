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
			this.buttonLogin = new Wisej.Web.Button();
			this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
			this.textBoxUsername = new Wisej.Web.TextBox();
			this.textBoxPassword = new Wisej.Web.TextBox();
			this.flexLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonLogin
			// 
			this.buttonLogin.Anchor = Wisej.Web.AnchorStyles.None;
			this.buttonLogin.Location = new System.Drawing.Point(3, 141);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(362, 37);
			this.buttonLogin.TabIndex = 2;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.Click += new System.EventHandler(this.button1_Click);
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.Controls.Add(this.textBoxUsername);
			this.flexLayoutPanel1.Controls.Add(this.textBoxPassword);
			this.flexLayoutPanel1.Controls.Add(this.buttonLogin);
			this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanel1.Location = new System.Drawing.Point(16, 75);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.Size = new System.Drawing.Size(368, 509);
			this.flexLayoutPanel1.TabIndex = 3;
			// 
			// textBoxUsername
			// 
			this.textBoxUsername.LabelText = "Username";
			this.textBoxUsername.Location = new System.Drawing.Point(3, 3);
			this.textBoxUsername.Name = "textBoxUsername";
			this.textBoxUsername.Size = new System.Drawing.Size(362, 53);
			this.textBoxUsername.TabIndex = 3;
			// 
			// textBoxPassword
			// 
			this.textBoxPassword.LabelText = "Password";
			this.textBoxPassword.Location = new System.Drawing.Point(3, 72);
			this.textBoxPassword.Name = "textBoxPassword";
			this.textBoxPassword.Size = new System.Drawing.Size(362, 53);
			this.textBoxPassword.TabIndex = 4;
			// 
			// Login
			// 
			this.Controls.Add(this.flexLayoutPanel1);
			this.Name = "Login";
			this.Title = "Login";
			this.Controls.SetChildIndex(this.flexLayoutPanel1, 0);
			this.flexLayoutPanel1.ResumeLayout(false);
			this.flexLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.Button buttonLogin;
		private Wisej.Web.FlexLayoutPanel flexLayoutPanel1;
		private Wisej.Web.TextBox textBoxUsername;
		private Wisej.Web.TextBox textBoxPassword;
	}
}
