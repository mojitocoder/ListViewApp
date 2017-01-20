using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListViewApp
{
	public partial class CustomCellPage : ContentPage
	{
		public CustomCellPage()
		{
			this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

			var listViewComponent = new ListView();
			listViewComponent.ItemsSource = new PluralSightTraining().GetAllCourses();
			listViewComponent.ItemTemplate = new DataTemplate(typeof(CustomCell));

			Content = listViewComponent;
		}
	}
}
