using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;

namespace LayoutLab
{	public class MainPage : ContentPage, IPage
	{
		public MainPage()
		{
			var grid = new Grid
                {
                    BackgroundColor = Color.Tan
                };
                grid.Children.Add(new Grid(){
                    BackgroundColor = Color.Blue,
					 WidthRequest = 150,
                    HeightRequest = 150,
                    HorizontalOptions = LayoutOptions.Start,
                    VerticalOptions = LayoutOptions.Start
                });

			Content = grid;
		}

		// int count = 0;

		// private void OnButtonClicked(object sender, EventArgs e)
		// {
		// 	count++;
		// 	CountLabel.Text = $"You clicked {count} times!";
		// }

		public IView View { get => (IView)Content; set => Content = (View)value; }
	}
}
