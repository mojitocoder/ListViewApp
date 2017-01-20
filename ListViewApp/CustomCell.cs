using System;
using Xamarin.Forms;

namespace ListViewApp
{
	public class CustomCell : ViewCell
	{
		public CustomCell()
		{
			var titleLabel = new Label();
			titleLabel.FontAttributes = FontAttributes.Bold;
			titleLabel.FontSize = Font.SystemFontOfSize(NamedSize.Medium).FontSize;
			titleLabel.SetBinding(Label.TextProperty, new Binding("Name"));
			titleLabel.TextColor = Color.Black;

			var authorLabel = new Label();
			authorLabel.FontAttributes = FontAttributes.None;
			authorLabel.FontSize = Font.SystemFontOfSize(NamedSize.Micro).FontSize;
			authorLabel.HorizontalTextAlignment = TextAlignment.End;
			authorLabel.HorizontalOptions = LayoutOptions.FillAndExpand;
			authorLabel.SetBinding(Label.TextProperty, new Binding("Author"));

			View = new StackLayout
			{
				Children = { titleLabel, authorLabel },
				Orientation = StackOrientation.Horizontal
				//Margin = new Thickness(10)
			};
		}
	}
}
