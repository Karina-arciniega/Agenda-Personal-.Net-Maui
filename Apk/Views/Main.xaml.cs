using Apk.Models;

namespace Apk.Views;

public partial class Main : ContentPage
{
	
    public Main(LoginPageViewModel viewModel)
    {
        InitializeComponent();
        this.BindingContext = viewModel;
    }
}