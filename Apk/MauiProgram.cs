using Apk.Models;
using Apk.Views;

namespace Apk;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddSingleton<inicio>();
        builder.Services.AddSingleton<Main>();

        builder.Services.AddSingleton<LoginPageViewModel>();
        builder.Services.AddSingleton<DashboardViewModel>();

        return builder.Build();

	}
}
