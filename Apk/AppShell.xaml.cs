using Apk.Models;
using Apk.Views;

namespace Apk;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(Main), typeof(Main));
	}
}
