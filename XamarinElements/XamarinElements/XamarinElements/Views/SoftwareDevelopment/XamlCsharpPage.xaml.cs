using System;

using Xamarin.Forms;

namespace XamarinElements.Views.SoftwareDevelopment
{
    public partial class XamlCsharpPage : ContentPage
	{	
		public XamlCsharpPage ()
		{
			InitializeComponent ();
			
		}

        void btnCsharpBack_Clicked(object sender, EventArgs e)
        {
			
			Navigation.PopModalAsync(true);
        }
    }
}

