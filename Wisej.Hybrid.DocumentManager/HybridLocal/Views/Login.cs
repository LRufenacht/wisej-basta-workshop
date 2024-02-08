using System;

namespace HybridLocal.Views
{
	public partial class Login : ViewBase
	{
		public Login()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			// perform login validation.

			// continue.
			this.NavigationService.RequestView(typeof(Discover));
			this.NavigationService.ShowNavigation();
		}
	}
}
