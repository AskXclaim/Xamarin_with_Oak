using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinElements.Views.Welcome;

namespace XamarinElements
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new XamlWelcomePage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

