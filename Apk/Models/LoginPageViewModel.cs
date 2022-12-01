using Apk.Views;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apk.Models
{
    public partial class LoginPageViewModel: BaseViewModel
    {
        #region Commands
        [ICommand]

        async void Login()
        {
            await Shell.Current.GoToAsync($"//{nameof(Main) }");
        }
        #endregion
    }
}
