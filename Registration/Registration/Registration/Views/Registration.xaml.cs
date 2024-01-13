using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Registration.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        public ICommand ClickCommand => new Command<string>
        ( (url) =>
             Browser.OpenAsync(url, BrowserLaunchMode.SystemPreferred));

        public Registration()
        {
            InitializeComponent();
            BindingContext = this;
            age.MinimumDate = DateTime.Now.AddYears(-80);
            age.MaximumDate = DateTime.Now;
            age.Date = DateTime.Today;
        }
    }
}