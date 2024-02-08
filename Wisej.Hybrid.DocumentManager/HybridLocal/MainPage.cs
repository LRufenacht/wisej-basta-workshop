using HybridLocal.Services;
using HybridLocal.Views;
using System;
using Wisej.Services;
using Wisej.Web;

namespace HybridLocal
{
	public partial class MainPage : Page
	{
		[Inject()]
		private NavigationService _navigationService { get; set; }

		public MainPage()
		{
			InitializeComponent();
		}

		private void MainPage_Load(object sender, EventArgs e)
		{
			this._navigationService.ViewRequested += _navigationService_ViewRequested;

			SwitchView(typeof(Login));
		}

		public void SwitchView(Type type)
		{
			this.panel1.Controls.Clear();

			// create new instance of view.
			var view = (ViewBase)Activator.CreateInstance(type);

			// inject services into view.
			Application.Services.Inject(view);

			// fill view to full screen.
			view.Dock = DockStyle.Fill;

			// add view to main page.
			this.panel1.Controls.Add(view);
		}

		private void _navigationService_ViewRequested(object sender, Type e)
		{
			SwitchView(e);
		}
	}
}
