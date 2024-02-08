using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using Wisej.Hybrid;
using Wisej.Hybrid.DocumentScanner;
using Wisej.Web;

namespace HybridLocal.Views
{
	public partial class AddDocument : ViewBase
	{
		private Image _image = null;

		public AddDocument()
		{
			InitializeComponent();
		}

		private async void uploadImage_Uploaded(object sender, UploadedEventArgs e)
		{
			var stream = e.Files[0].InputStream;
			this._image = Image.FromStream(stream);

			this.pictureBoxPreview.Image = this._image;

			var result = (await this.tesseract1.ScanImageAsync(this._image));

			this.textBoxImageText.Text = result.Text;

			Application.Update(this);
		}

		private async void buttonScan_Click(object sender, EventArgs e)
		{
			var docs = Device.Use<DeviceDocumentScanner>().Scan(640, 480, 0.25);
			this._image = docs.FirstOrDefault();

			this.pictureBoxPreview.Image = this._image;

			var result = (await this.tesseract1.ScanImageAsync(this._image));

			this.textBoxImageText.Text = result.Text;

			Application.Update(this);
		}

		private void buttonSave_Click(object sender, EventArgs e)
		{
			if (!Directory.Exists(this.DocumentsDirectory))
				Directory.CreateDirectory(this.DocumentsDirectory);

			var time = DateTime.Now.Ticks;
			var targetPath = Path.Combine(DocumentsDirectory, $"{time}.jpg");
			this._image.Save(targetPath, ImageFormat.Jpeg);

			var dataTargetPath = Path.ChangeExtension(targetPath, ".txt");
			File.WriteAllText(dataTargetPath, this.textBoxImageText.Text);

			AlertBox.Show("Saved");
		}
	}
}
