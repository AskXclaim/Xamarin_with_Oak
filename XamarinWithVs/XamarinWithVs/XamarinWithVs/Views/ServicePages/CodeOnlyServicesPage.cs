using Xamarin.Forms;
using XamarinWithVs.Views.ServicePages;

namespace XamarinWithVs.Views.HomePages
{
    public class CodeOnlyServicesPage : CarouselPage
	{
		public CodeOnlyServicesPage ()
        {
            Title = "Services";
            AddCarouselPages();
        }

        private void AddCarouselPages()
        {
            Children.Add(new SoftwareDevPage());
            Children.Add(new CodeOnlyCyberSecurityPage());
        }

    }
}


