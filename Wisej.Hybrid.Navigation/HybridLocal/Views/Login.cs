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
			this.NavigationService.RequestView(typeof(Home));
			this.NavigationService.ShowNavigation();
		}
	}
}
