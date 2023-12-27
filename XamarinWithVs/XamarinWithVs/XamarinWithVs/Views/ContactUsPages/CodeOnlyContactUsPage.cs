using Xamarin.Forms;

namespace XamarinWithVs.Views.ContactUsPages
{
    public class CodeOnlyContactUsPage : TabbedPage
	{
		public CodeOnlyContactUsPage ()
		{
            Children.Add(GetLocationContent());
            Children.Add(GetDigitalContent());
            Children.Add(GetFeedBackContent());
        }

        private ContentPage GetLocationContent() => new CodeOnlyLocationPage();

        private ContentPage GetDigitalContent() => new CodeOnlyDigitalPage();

        private ContentPage GetFeedBackContent() => new CodeOnlyFeedBackPage();
    }
}


