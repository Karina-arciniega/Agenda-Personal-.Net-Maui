using Apk.Handlers;

namespace Apk;

public partial class App : Application
{
	public App()
	{
        Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("NzcyMDY1QDMyMzAyZTMzMmUzMEF4N3BDeU50OE5QL1NhaEd2M1JST09KaXVjeVJpZlVSY2M5U1M1bUxRN1E9");

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
