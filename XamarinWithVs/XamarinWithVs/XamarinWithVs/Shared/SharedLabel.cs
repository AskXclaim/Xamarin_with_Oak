using Xamarin.Forms;

namespace XamarinWithVs.Shared
{
    public static class SharedLabel
    {
        public static Label GetCenteredLabel(string text, Thickness? margin = null, byte? size = null) => new Label
        {
            Text = text,
            Margin = margin ?? GetDefaultMargin(),
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
            FontSize = size ?? 15,
            FontAttributes = FontAttributes.Bold
        };

        public static Label GetCenteredAndExpandedLabel(string text, Thickness? margin = null, byte? size = null) => new Label
        {
            Text = text,
            Margin = margin ?? GetDefaultMargin(),
            VerticalOptions = LayoutOptions.CenterAndExpand,
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            FontSize = size ?? 15,
            FontAttributes = FontAttributes.Bold
        };

        public static Thickness GetDefaultMargin() => new Thickness(5, 10);

        public static Thickness GetFiveThreeMargin() => new Thickness(5, 3);
    }
}

