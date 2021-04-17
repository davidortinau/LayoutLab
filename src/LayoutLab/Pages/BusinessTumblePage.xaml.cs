using System.Collections.Generic;

using System;
using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace LayoutLab
{
	public partial class BusinessTumblePage : ContentPage, IPage
	{
		public BusinessTumblePage ()
		{
			InitializeComponent ();
		}

		public override string ToString(){
			return this.Title;
		}

		public IView View { get => (IView)Content; set => Content = (View)value; }
	}
}

