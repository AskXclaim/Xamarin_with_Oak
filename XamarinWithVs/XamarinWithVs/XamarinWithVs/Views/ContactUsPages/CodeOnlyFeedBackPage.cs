using Xamarin.Forms;

namespace XamarinWithVs.Views.ContactUsPages
{
    public class CodeOnlyFeedBackPage : ContentPage
    {
        public CodeOnlyFeedBackPage()
        {
            Title = "Feed Back";
            IconImageSource = "feedBackIcon.png";
            Content = new StackLayout
            {
                Children = {
                    Shared.SharedLabel.GetCenteredLabel("We would love to know what you think")

                }
            };
        }
    }
}


