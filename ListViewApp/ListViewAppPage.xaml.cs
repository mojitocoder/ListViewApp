using Xamarin.Forms;
using System.Linq;
using System.Collections.Generic;

namespace ListViewApp
{
	public partial class ListViewAppPage : ContentPage
	{
		public ListViewAppPage()
		{
			this.Padding = new Thickness(0, Device.OnPlatform(20, 0, 0), 0, 0);

			var listViewComponent = new ListView();
			listViewComponent.ItemsSource = new PluralSightTraining().GetAllCourses();//.Select(foo => foo.Name);

			this.Content = listViewComponent;
			//InitializeComponent();
		}
	}
}
