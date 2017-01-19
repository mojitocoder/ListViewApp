using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListViewApp
{
	public partial class TextCellPage : ContentPage
	{
		public TextCellPage()
		{
			this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

			var listViewComponent = new ListView();
			listViewComponent.ItemsSource = new PluralSightTraining().GetAllCourses();

			var cell = new DataTemplate(typeof(TextCell));
			cell.SetBinding(TextCell.TextProperty, new Binding("Author"));
			cell.SetValue(TextCell.TextColorProperty, Color.Accent);

			cell.SetBinding(TextCell.DetailProperty, new Binding("Name"));
			cell.SetValue(TextCell.DetailColorProperty, Color.Black);

			listViewComponent.ItemTemplate = cell;
			this.Content = listViewComponent;
		}
	}
}
