namespace HybridLocal.Views
{
	partial class AddDocument
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
			this.components = new System.ComponentModel.Container();
			this.flexLayoutPanel1 = new Wisej.Web.FlexLayoutPanel();
			this.uploadImage = new Wisej.Web.Upload();
			this.buttonScan = new Wisej.Web.Button();
			this.pictureBoxPreview = new Wisej.Web.PictureBox();
			this.tagTextBoxImageText = new Wisej.Web.TagTextBox();
			this.buttonSave = new Wisej.Web.Button();
			this.tesseract1 = new Wisej.Ext.Tesseract.Tesseract(this.components);
			this.flexLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
			this.SuspendLayout();
			// 
			// flexLayoutPanel1
			// 
			this.flexLayoutPanel1.AutoScroll = true;
			this.flexLayoutPanel1.AutoScrollMargin = new System.Drawing.Size(0, 20);
			this.flexLayoutPanel1.Controls.Add(this.uploadImage);
			this.flexLayoutPanel1.Controls.Add(this.buttonScan);
			this.flexLayoutPanel1.Controls.Add(this.pictureBoxPreview);
			this.flexLayoutPanel1.Controls.Add(this.tagTextBoxImageText);
			this.flexLayoutPanel1.Controls.Add(this.buttonSave);
			this.flexLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill;
			this.flexLayoutPanel1.LayoutStyle = Wisej.Web.FlexLayoutStyle.Vertical;
			this.flexLayoutPanel1.Location = new System.Drawing.Point(16, 75);
			this.flexLayoutPanel1.Name = "flexLayoutPanel1";
			this.flexLayoutPanel1.Size = new System.Drawing.Size(368, 509);
			this.flexLayoutPanel1.TabIndex = 2;
			// 
			// uploadImage
			// 
			this.uploadImage.AllowedFileTypes = "image/*";
			this.uploadImage.Location = new System.Drawing.Point(3, 3);
			this.uploadImage.Name = "uploadImage";
			this.uploadImage.Size = new System.Drawing.Size(362, 37);
			this.uploadImage.TabIndex = 0;
			this.uploadImage.Text = "Select from Gallery";
			this.uploadImage.Uploaded += new Wisej.Web.UploadedEventHandler(this.uploadImage_Uploaded);
			// 
			// buttonScan
			// 
			this.buttonScan.Location = new System.Drawing.Point(3, 56);
			this.buttonScan.Name = "buttonScan";
			this.buttonScan.Size = new System.Drawing.Size(362, 37);
			this.buttonScan.TabIndex = 3;
			this.buttonScan.Text = "Scan Document";
			this.buttonScan.Click += new System.EventHandler(this.buttonScan_Click);
			// 
			// pictureBoxPreview
			// 
			this.pictureBoxPreview.Location = new System.Drawing.Point(3, 109);
			this.pictureBoxPreview.Name = "pictureBoxPreview";
			this.pictureBoxPreview.Size = new System.Drawing.Size(362, 206);
			this.pictureBoxPreview.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom;
			// 
			// tagTextBoxImageText
			// 
			this.tagTextBoxImageText.Location = new System.Drawing.Point(3, 331);
			this.tagTextBoxImageText.Name = "tagTextBoxImageText";
			this.tagTextBoxImageText.SeparatorChar = ' ';
			this.tagTextBoxImageText.Size = new System.Drawing.Size(362, 30);
			this.tagTextBoxImageText.TabIndex = 5;
			// 
			// buttonSave
			// 
			this.buttonSave.Location = new System.Drawing.Point(3, 377);
			this.buttonSave.Name = "buttonSave";
			this.buttonSave.Size = new System.Drawing.Size(362, 37);
			this.buttonSave.TabIndex = 4;
			this.buttonSave.Text = "Save Image";
			this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
			// 
			// tesseract1
			// 
			this.tesseract1.MinimumConfidence = 60;
			// 
			// AddDocument
			// 
			this.Controls.Add(this.flexLayoutPanel1);
			this.Name = "AddDocument";
			this.Title = "New Document";
			this.Controls.SetChildIndex(this.flexLayoutPanel1, 0);
			this.flexLayoutPanel1.ResumeLayout(false);
			this.flexLayoutPanel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Wisej.Web.FlexLayoutPanel flexLayoutPanel1;
		private Wisej.Web.Upload uploadImage;
		private Wisej.Web.PictureBox pictureBoxPreview;
		private Wisej.Ext.Tesseract.Tesseract tesseract1;
		private Wisej.Web.Button buttonScan;
		private Wisej.Web.Button buttonSave;
		private Wisej.Web.TagTextBox tagTextBoxImageText;
	}
}
