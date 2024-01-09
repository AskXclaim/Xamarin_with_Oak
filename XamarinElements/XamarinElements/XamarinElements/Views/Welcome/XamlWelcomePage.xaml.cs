using Xamarin.Forms;
using XamarinElements.Views.ContactUs;
using XamarinElements.Views.CyberSecurity;
using XamarinElements.Views.OtherServices;
using XamarinElements.Views.ReportFault;
using XamarinElements.Views.SoftwareDevelopment;

namespace XamarinElements.Views.Welcome
{
    public partial class XamlWelcomePage : ContentPage
    {
        public XamlWelcomePage()
        {
            InitializeComponent();
     
        }

        public void  OnAppearing()
        {
            otherServicePicker.SelectedIndex = -1;
            otherServicePicker.Title = "Other Services";
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

        void contactUsToolbarItem_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new XamlContactUs());
        }

        void otherServicePicker_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var picker = (Picker)sender;
            var selectedItem = picker.SelectedItem;
            switch (selectedItem.ToString().ToLower())
            {
                case "testing":
                    Navigation.PushAsync(GetCarouselPage(0));
                    break;
                case "devops":
                    Navigation.PushAsync(GetCarouselPage(1));
                    break;
                default:
                    break;
            }
        }

        private CodeOnlyOtherServicesPage GetCarouselPage(byte pageIndex)
        {
            var page = new CodeOnlyOtherServicesPage();
            page.CurrentPage = page.Children[pageIndex];
            return page;
        }

        void reportFaultToolbarItem_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new CodeOnlyReportFaultPage());
        }
    }
}

