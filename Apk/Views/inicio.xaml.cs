using Apk.Models;

namespace Apk.Views;

public partial class inicio : ContentPage
{
	public inicio(LoginPageViewModel viewModel)
	{
		InitializeComponent();
		this.BindingContext= viewModel;
	}

    
}