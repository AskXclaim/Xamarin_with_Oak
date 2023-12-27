using Xamarin.Forms;

namespace XamarinWithVs.Views.ContactUsPages
{
    public class CodeOnlyDigitalPage : ContentPage
    {
        public CodeOnlyDigitalPage()
        {
            Title = "Email/Phone";
            IconImageSource = "emailPhoneIcon.png";
            Content = new StackLayout
            {
                Children = {
                    Shared.SharedLabel.GetCenteredLabel("Email:contactus@lyseis.com"),
                    Shared.SharedLabel.GetCenteredLabel("Phone: 01234545666",
                    Shared.SharedLabel.GetFiveThreeMargin()),
                }
            };
        }
    }
}


