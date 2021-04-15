using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace LayoutLab
{	public class SpacingStackPage : ContentPage, IPage
	{
		public SpacingStackPage()
		{
			this.Content = new StackLayout
            {
                Margin = new Thickness(20),
                Spacing = 0,
                Children =
                {
                    new Label { Text = "Primary colors" },
                    new BoxView { Color = Color.Red },
                    new BoxView { Color = Color.Yellow },
                    new BoxView { Color = Color.Blue },
                    new Label { Text = "Secondary colors" },
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
