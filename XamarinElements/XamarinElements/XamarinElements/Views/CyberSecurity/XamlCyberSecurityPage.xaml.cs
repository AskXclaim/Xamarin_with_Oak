using Xamarin.Forms;

namespace XamarinElements.Views.CyberSecurity
{
    public partial class XamlCyberSecurityPage : ContentPage
	{	
		public XamlCyberSecurityPage ()
		{
			InitializeComponent ();
		}

        void btnCyberSecurityBack_Clicked(object sender, System.EventArgs e)
        {
			Navigation.PopAsync();
        }
    }
}

