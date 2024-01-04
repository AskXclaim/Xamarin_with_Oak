using System.Collections.Generic;
using Xamarin.Forms;

namespace XamarinElements.Shared
{
    public static class Elements
    {
        public static StackLayout GetStackLayout
            (StackLayoutCall stackLayoutCall)
            => new StackLayout()
            {
                BackgroundColor = stackLayoutCall.BackGroundColor ?? Color.Azure,
                Padding = stackLayoutCall.Padding ?? new Thickness(5, 5, 5, 5),
                HorizontalOptions = stackLayoutCall.HorizontalLayout ?? LayoutOptions.Fill,
                VerticalOptions = stackLayoutCall.VerticalLayout ?? LayoutOptions.Center
            };

        public static Label GetLabel(LabelCall labelCall) => new Label()
        {
            Text = labelCall.Text,
            TextColor = labelCall.TextColor ?? Color.White,
            FontSize = labelCall.FontSize,
            BackgroundColor = labelCall.BackgroundColor,
            Padding = new Thickness(5),
            HorizontalTextAlignment = TextAlignment.Center
        };

        public static Button GetBackButton() => new Button()
        {
            Text = "Go back",
            TextColor = Color.FromHex("#000000"),
            CornerRadius = 10,
            FontSize = 15
        };

        public static TabbedPage GetTabbedPage(List<Page> pages)
        {
            if (pages == null || pages.Count == 0)
                throw new System.Exception($"{nameof(pages)} cannot be null or empty");

            var tabbedPage = new TabbedPage();
            foreach (var page in pages)
                tabbedPage.Children.Add(page);

            return tabbedPage;
        }

        public static ContentPage GetContentPage(string title, string iconSource, StackLayout stackLayout)
        => new ContentPage()
        {
            Title = title?.Trim(),
            IconImageSource = !string.IsNullOrWhiteSpace(iconSource) ? iconSource : "",
            Content = stackLayout
        };




    }
}

