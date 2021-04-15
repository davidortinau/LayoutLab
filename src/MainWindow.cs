using Microsoft.Maui;

namespace LayoutLab
{
	public class MainWindow : IWindow
	{
		public MainWindow()
		{
		}

		public IPage Page { get; set; }

		public IMauiContext MauiContext { get; set; }
	}
}