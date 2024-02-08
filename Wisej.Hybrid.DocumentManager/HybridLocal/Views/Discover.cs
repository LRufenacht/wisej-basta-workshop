using System;
using System.IO;
using Wisej.Web;

namespace HybridLocal.Views
{
	public partial class Discover : ViewBase
	{
		public Discover()
		{
			InitializeComponent();
		}

		private void Home_Load(object sender, EventArgs e)
		{
			if (Directory.Exists(this.DocumentsDirectory)) 
			{
				var documents = Directory.GetFiles(DocumentsDirectory, "*.jpg");

				foreach (var document in documents)
				{
					this.flexLayoutPanel1.Controls.Add(new Label(Path.GetFileName(document)));
				}
			}
		}

		private void textBoxSearch_TextChanged(object sender, EventArgs e)
		{

		}
	}
}
