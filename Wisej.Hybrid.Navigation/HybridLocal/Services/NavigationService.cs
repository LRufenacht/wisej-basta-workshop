using HybridLocal.Views;
using System;
using Wisej.Hybrid;

namespace HybridLocal.Services
{
	internal class NavigationService
	{
		public event EventHandler<Type> ViewRequested;

		public void RequestView(Type type)
		{
			this.ViewRequested?.Invoke(this, type);
		}

		public void ShowNavigation()
		{
			Device.TabBar.TabSelected -= TabBar_TabSelected;
			Device.TabBar.TabSelected += TabBar_TabSelected;

			Device.TabBar.Items =
			[
				new()
				{
					Title = "Home",
					Selected = true,
					ImageSource = Wisej.Ext.MaterialDesign.Icons.HomeButton
				},
				new() {
					Title = "Add",
					ImageSource = Wisej.Ext.MaterialDesign.Icons.CreateNewPencilButton
				},
				new()
				{
					Title = "Search",
					ImageSource = Wisej.Ext.MaterialDesign.Icons.SearchingMagnifyingGlass
				}
			];

			Device.TabBar.Visible = true;
		}

		public void HideNavigation()
		{
			Device.TabBar.Visible = false;
		}

		private void TabBar_TabSelected(object sender, Wisej.Hybrid.Shared.TabBar.TabSelectedEventArgs e)
		{
			switch (e.SelectedTabBarItem.Title)
			{
				case "Home":
					RequestView(typeof(Home));
					break;

				case "Add":
					RequestView(typeof(AddDocument));
					break;

				case "Search":
					RequestView(typeof(Search));
					break;
			}
		}
	}
}
