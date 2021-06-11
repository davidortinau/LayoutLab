using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Compatibility;

namespace LayoutLab
{
	public class Startup : IStartup
	{
		public void Configure(IAppHostBuilder appBuilder)
		{
			appBuilder
				.UseFormsCompatibility(false)
				#if __ANDROID__
				.ConfigureMauiHandlers(handlers => {
					handlers.AddCompatibilityRenderer(typeof(Microsoft.Maui.Controls.BoxView), 
						typeof(Microsoft.Maui.Controls.Compatibility.Platform.Android.BoxRenderer));
					handlers.AddCompatibilityRenderer(typeof(Microsoft.Maui.Controls.Frame), 
						typeof(Microsoft.Maui.Controls.Compatibility.Platform.Android.FastRenderers.FrameRenderer));	
				})
				#endif
				#if __IOS__
				.ConfigureMauiHandlers(handlers => {
					handlers.AddCompatibilityRenderer(typeof(Microsoft.Maui.Controls.BoxView), 
						typeof(Microsoft.Maui.Controls.Compatibility.Platform.iOS.BoxRenderer));
					handlers.AddCompatibilityRenderer(typeof(Microsoft.Maui.Controls.Frame), 
						typeof(Microsoft.Maui.Controls.Compatibility.Platform.iOS.FrameRenderer));
					handlers.AddCompatibilityRenderer(typeof(Microsoft.Maui.Controls.ScrollView), 
						typeof(Microsoft.Maui.Controls.Compatibility.Platform.iOS.ScrollViewRenderer));
				})
				#endif
				.UseMauiApp<App>();
		}
	}
}