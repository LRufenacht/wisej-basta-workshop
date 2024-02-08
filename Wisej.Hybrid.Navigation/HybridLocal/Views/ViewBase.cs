using HybridLocal.Services;
using System;
using Wisej.Services;
using Wisej.Web;

namespace HybridLocal.Views
{
	public partial class ViewBase : Wisej.Web.UserControl
	{
		[Inject()]
		internal NavigationService NavigationService { get; set; }

		public ViewBase()
		{
			InitializeComponent();
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
