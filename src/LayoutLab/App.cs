using Microsoft.Maui;
using Microsoft.Maui.Controls;

namespace LayoutLab
{
	public class App : IApplication
	{
		public IWindow CreateWindow(IActivationState activationState)
		{
			Microsoft.Maui.Controls.Compatibility.Forms.Init(activationState);
			return new MainWindow{
				Page = new BugSweeper.BugSweeperPage()
			};
		}		
	}
}