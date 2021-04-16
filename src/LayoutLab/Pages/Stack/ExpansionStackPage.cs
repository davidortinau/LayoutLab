using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace LayoutLab
{	public class ExpansionStackPage : ContentPage, IPage
	{
		public ExpansionStackPage()
		{
			BackgroundColor = Color.White;
			this.Content = new StackLayout
			{
				Margin = new Thickness(20),
				Children = {
					new BoxView { BackgroundColor = Color.Red, HeightRequest = 1 },
					new Label { Text = "StartAndExpand", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.StartAndExpand },
					new BoxView { BackgroundColor = Color.Red, HeightRequest = 1 },
					new Label { Text = "CenterAndExpand", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.CenterAndExpand },
					new BoxView { BackgroundColor = Color.Red, HeightRequest = 1 },
					new Label { Text = "EndAndExpand", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.EndAndExpand },
					new BoxView { BackgroundColor = Color.Red, HeightRequest = 1 },
					new Label { Text = "FillAndExpand", BackgroundColor = Color.Gray, VerticalOptions = LayoutOptions.FillAndExpand },
					new BoxView { BackgroundColor = Color.Red, HeightRequest = 1 }
				}
			};
		}

		//public IView View { get;set; }
        public IView View { get => (IView)Content; set => Content = (View)value; }
	}
}
