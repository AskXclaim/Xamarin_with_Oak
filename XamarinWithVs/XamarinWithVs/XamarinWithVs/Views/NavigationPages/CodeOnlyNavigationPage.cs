using System.Collections;
using Xamarin.Forms;

namespace XamarinWithVs.Views.NavigationPages
{
    public class CodeOnlyNavigationPage : ContentPage
    {
        public CodeOnlyNavigationPage()
        {
            Title = "CodeOnly";
            SetToolbarItems();
            EnsureSingleDefaultOrPrimaryOrder();
            Content = GetFrame(GetStackLayout(GetLabel("Welcome to CodeOnly Navigation Page!")));
        }

        private void SetToolbarItems()
        {
            ToolbarItems.Add(GetToolbarItem("Home", "homeIcon.png", ToolbarItemOrder.Default));
            ToolbarItems.Add(GetToolbarItem("Services", "servicesIcon.png", ToolbarItemOrder.Secondary));
            ToolbarItems.Add(GetToolbarItem("Contact us", "contactUsIcon.png", ToolbarItemOrder.Secondary));
        }

        private ToolbarItem GetToolbarItem(string text, string iconImgSrc, ToolbarItemOrder order)
            => new ToolbarItem()
            {
                Text = text,
                IconImageSource = iconImgSrc,
                Order = order,
            };

        private void EnsureSingleDefaultOrPrimaryOrder()
        {
            var isDefaultOrPrimarySet = false;
            foreach (var item in ToolbarItems)
            {
                if (isDefaultOrPrimarySet == false &&
                    (item.Order == ToolbarItemOrder.Default
                    || item.Order == ToolbarItemOrder.Primary))
                {
                    isDefaultOrPrimarySet = true;
                    continue;
                }

                if (isDefaultOrPrimarySet == true &&
                   (item.Order == ToolbarItemOrder.Default
                   || item.Order == ToolbarItemOrder.Primary))
                {
                    item.Order = ToolbarItemOrder.Secondary;
                    continue;
                }
            }
        }

        private Frame GetFrame(StackLayout stackLayout) => new Frame()
        {
            IsClippedToBounds = true,
            CornerRadius = 30,
            Padding = new Thickness(1, 2),
            BackgroundColor = stackLayout.BackgroundColor
        };

        private StackLayout GetStackLayout(Label label) => new StackLayout()
        {
            Padding = 5,
            BackgroundColor = label.BackgroundColor,
        };

        private Label GetLabel(string text) => new Label()
        {
            Text = text,
            FontSize = 25,
            TextColor = Color.SlateGray,
        };


    }
}


