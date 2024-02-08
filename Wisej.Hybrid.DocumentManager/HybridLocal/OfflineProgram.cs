using HybridLocal.Services;
using Wisej.Web;

namespace HybridLocal
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			Application.Services.AddService<NavigationService>();

			Application.MainPage = new MainPage();
		}
	}
}