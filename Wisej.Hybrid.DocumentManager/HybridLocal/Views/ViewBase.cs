using HybridLocal.Services;
using System.ComponentModel;
using System.IO;
using Wisej.Hybrid;
using Wisej.Services;

namespace HybridLocal.Views
{
	public partial class ViewBase : Wisej.Web.UserControl
	{
		[Inject()]
		internal NavigationService NavigationService { get; set; }

		internal readonly string DocumentsDirectory;

		public ViewBase()
		{
			InitializeComponent();

			if (LicenseManager.UsageMode == LicenseUsageMode.Runtime)
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
