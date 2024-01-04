using Xamarin.Forms;
using XamarinElements.Views.ContactUs;
using XamarinElements.Views.CyberSecurity;
using XamarinElements.Views.SoftwareDevelopment;

namespace XamarinElements.Views.Welcome
{
    public partial class XamlWelcomePage : ContentPage
	{	
		public XamlWelcomePage ()
		{
			InitializeComponent ();
		}

        void btnSoftwareDev_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushModalAsync(new CodeOnlySoftwareDevMainPage());
        }

        void btnCyberSecurity_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new XamlCyberSecurityPage());
        }

        void welcomeToolbarItem_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PopToRootAsync();
        }

        void softwareDevToolbarItem_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CodeOnlySoftwareDevMainPage());
        }

        void cyberSecurityToolbarItem_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new XamlCyberSecurityPage());
        }

        void contactUsToolbarItem_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new XamlContactUs());
        }
    }
}

