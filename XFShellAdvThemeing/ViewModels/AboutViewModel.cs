using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace XFShellAdvThemeing.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "Account";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("http://nomoninja.com"));
        }

        public ICommand OpenWebCommand { get; }
    }
}