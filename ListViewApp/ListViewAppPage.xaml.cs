using Xamarin.Forms;
using System.Linq;
using System.Collections.Generic;
using System.Diagnostics;

namespace ListViewApp
{
	public partial class ListViewAppPage : ContentPage
	{
		public ListViewAppPage()
		{
			this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

			var listViewComponent = new ListView();
			listViewComponent.ItemsSource = new PluralSightTraining().GetAllCourses();//.Select(foo => foo.Name);


			// *************************************
			// ListView supports the following events
			// *************************************
			//ItemAppearing: Occurs when the visual representation of an item is being added to the visual layout.
			//ItemDisappearing: Occurs when the visual representation of an item is being removed from the visual layout.
			//ItemSelected: Event that is raised when a new item is selected.
			//ItemTapped:  Event that is raised when an item is tapped.
			//Refreshing:  Event that is raised when the list view refreshes.

			//attach an event-handler
			listViewComponent.ItemSelected += ItemSelectedEventHandler;


			this.Content = listViewComponent;
			//InitializeComponent();
		}

		public void ItemSelectedEventHandler(object sender, SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem != null)
			{
				Debug.WriteLine($"ItemSelected: {e.SelectedItem}");
				(sender as ListView).SelectedItem = null;
			}
		}
	}
}
