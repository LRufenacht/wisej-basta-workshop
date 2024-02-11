using HybridLocal.Services;
using System.ComponentModel;
using System.IO;
using Wisej.Hybrid;
using Wisej.Services;
using Wisej.Web;

namespace HybridLocal.Views
{
	public partial class ViewBase : Wisej.Web.UserControl
	{
		[Inject]
		internal NavigationService NavigationService { get; set; }

		internal readonly string DocumentsDirectory;

		public ViewBase()
		{
			InitializeComponent();

			Application.Services.Inject(this);

			if (Application.RuntimeMode)
				this.DocumentsDirectory = Path.Combine(Device.Info.FileSystem.LocalApplicationData, "Documents");
		}

		public string Title
		{
			get
			{
				return this.labelTitle.Text;
			}
			set
			{
				this.labelTitle.Text = value;
			}
		}
	}
}
