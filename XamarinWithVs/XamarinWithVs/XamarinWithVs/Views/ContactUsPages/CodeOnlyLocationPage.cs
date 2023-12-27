using Xamarin.Forms;
using XamarinWithVs.Shared;

namespace XamarinWithVs.Views.ContactUsPages
{
    public class CodeOnlyLocationPage : ContentPage
    {
        public CodeOnlyLocationPage()
        {
            Title = "Address";
            IconImageSource = "locationIcon.png";
            Content = new StackLayout
            {
                Children = {
                  SharedLabel.GetCenteredLabel("Here's our address:"),
                  SharedLabel.GetCenteredLabel("103 Bella Road, Ontario",
                  SharedLabel.GetFiveThreeMargin())
                }

            };
        }


    }
}


