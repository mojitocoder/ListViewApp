using Xamarin.Forms;

namespace ListViewApp
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var tabs = new TabbedPage { Title = "Tabbed Lists", Icon = "" };
			tabs.Children.Add(new ListViewAppPage { Title = "Simple" });
			tabs.Children.Add(new TextCellPage { Title = "Cell" });

			MainPage = tabs;

			//MainPage = new ListViewAppPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
