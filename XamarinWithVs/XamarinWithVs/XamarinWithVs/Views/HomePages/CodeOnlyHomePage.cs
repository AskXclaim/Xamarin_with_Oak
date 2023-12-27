using System;

using Xamarin.Forms;

namespace XamarinWithVs.Views.HomePages
{
    public class CodeOnlyHomePage : ContentPage
    {
        public CodeOnlyHomePage()
        {
            Title = "Home";
            BackgroundColor = Color.WhiteSmoke;
            Content = GetFrame(GetStackLayout(GetLabel("Welcome to Lyseis code only home page!")));
        }

        private Frame GetFrame(StackLayout stackLayout) => new Frame()
        {
            IsClippedToBounds = true,
            Padding = 1,
            CornerRadius = 30,
            BackgroundColor = stackLayout.BackgroundColor,
            Content = stackLayout
        };

        private StackLayout GetStackLayout(Label label) => new StackLayout()
        {
            Padding = 5,
            Margin = new Thickness(5, 10),
            HorizontalOptions = LayoutOptions.CenterAndExpand,
            VerticalOptions = LayoutOptions.CenterAndExpand,
            Children = { label }
        };

        private Label GetLabel(string text) => new Label()
        {
            FontSize = 20,
            TextColor = Color.BlueViolet,
            Text = text
        };
    }
}


