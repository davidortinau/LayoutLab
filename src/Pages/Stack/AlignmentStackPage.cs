using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace LayoutLab
{	public class AlignmentStackPage : ContentPage, IPage
	{
		public AlignmentStackPage()
		{
			this.Content = new StackLayout
			{
				Margin = new Thickness(20),
				Children =
                {
					new Label { Text = "Start", BackgroundColor = Color.Gray, HorizontalOptions = LayoutOptions.Start },
					new Label { Text = "Center", BackgroundColor = Color.Gray, HorizontalOptions = LayoutOptions.Center },
					new Label { Text = "End", BackgroundColor = Color.Gray, HorizontalOptions = LayoutOptions.End },
					new Label { Text = "Fill", BackgroundColor = Color.Gray, HorizontalOptions = LayoutOptions.Fill }
				}
			};
		}

		//public IView View { get;set; }
        public IView View { get => (IView)Content; set => Content = (View)value; }
	}
}
