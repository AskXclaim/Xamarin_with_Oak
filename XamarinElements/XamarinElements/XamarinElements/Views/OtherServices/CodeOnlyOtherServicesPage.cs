using System;

using Xamarin.Forms;

namespace XamarinElements.Views.OtherServices
{
    public class CodeOnlyOtherServicesPage : CarouselPage
    {
        public CodeOnlyOtherServicesPage()
        {
            Title = "Other Services";
            Children.Add(GetContentPage("Testing", "Learn more about our testing service"));
            Children.Add(GetContentPage("DevOps", "Learn more about our DevOps service"));

        }

        private ContentPage GetContentPage(string pageTitle, string text) => new ContentPage()
        {
            Title = pageTitle,
            Content = new StackLayout()
            {
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children = {new Label()
                    {
                        TextColor=Color.FromHex("#000000"),
                        FontSize= Device.GetNamedSize(NamedSize.Large, typeof(Label)),
                        FontAttributes= FontAttributes.Bold | FontAttributes.Italic,
                        Text=text
                    }
                    }
            }
        };
    }

}


