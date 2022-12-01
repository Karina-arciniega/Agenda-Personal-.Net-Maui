using Apk.Models;

namespace Apk.Views;

public partial class Main : ContentPage
{
	public Main(DashboardViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext = viewModel;
	}
}