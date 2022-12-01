using Microsoft.Toolkit.Mvvm.ComponentModel;
using ObservableObject = Microsoft.Toolkit.Mvvm.ComponentModel.ObservableObject;

namespace Apk.Models
{
    public partial class BaseViewModel: ObservableObject
    {
        [ObservableProperty]
        private bool is_busy;

        [ObservableProperty]
        private string _title;
    }
}
