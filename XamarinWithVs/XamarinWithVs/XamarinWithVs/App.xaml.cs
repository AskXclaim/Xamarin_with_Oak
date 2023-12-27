using Xamarin.Forms;
using XamarinWithVs.Views.ContactUsPages;
using XamarinWithVs.Views.HomePages;
using XamarinWithVs.Views.MasterDetailPages;
using XamarinWithVs.Views.NavigationPages;

namespace XamarinWithVs
{
    public partial class App : Application
    {
      
        public App()
        {
            InitializeComponent();

            //  MainPage = new MainPage();

            // MainPage = new CodeOnlyHomePage();
            // MainPage = new XamlHomePage();
            //MainPage = new NavigationPage(new CodeOnlyNavigationPage());
            //MainPage = new NavigationPage(new XamlNavigationPage());
            //MainPage = new CodeOnlyContactUsPage();
            //MainPage = new XamlContactUsPage();
            //MainPage = new CodeOnlyServicesPage();
           // MainPage = new CodeOnlyMasterDetailPage();
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

