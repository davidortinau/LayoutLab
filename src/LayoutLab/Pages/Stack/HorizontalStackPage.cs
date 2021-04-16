using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace LayoutLab
{	public class HorizontalStackPage : ContentPage, IPage
	{
		public HorizontalStackPage()
		{
            BackgroundColor = Color.White;
			this.Content = new StackLayout
            {
                Margin = new Thickness(20),
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.Center,
                Children =
                {
                    new BoxView { Color = Color.Red },
                    new BoxView { Color = Color.Yellow },
                    new BoxView { Color = Color.Blue },
                    new BoxView { Color = Color.Green },
                    new BoxView { Color = Color.Orange },
                    new BoxView { Color = Color.Purple }
                }
            };
		}

		//public IView View { get;set; }
        public IView View { get => (IView)Content; set => Content = (View)value; }
	}
}
