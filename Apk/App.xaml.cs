using Apk.Handlers;

namespace Apk;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping(nameof(BordelessEntry), (handler, view) =>
		{ 
			if (view is BordelessEntry)
			{
				#if ANDROID

				//handler.PlatformView.SetBackgroundColor(Color.Transparent.TopPlataform());

				#endif
			}
		});

		MainPage = new AppShell();
	}
}
