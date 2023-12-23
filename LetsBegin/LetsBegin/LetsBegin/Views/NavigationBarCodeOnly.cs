using Xamarin.Forms;

namespace LetsBegin.Views
{
    public class NavigationBarCodeOnly : ContentPage
    {
        public NavigationBarCodeOnly()
        {
            Title = "Code-Only-Navigation-page";
            Content = new StackLayout()
            {
                Children =
                {
                    new Label()
                    {
                        Text = "Welcome to Code only Nav page.",
                        FontSize = 40.0
                    }
                }
            };
            ToolbarItems.Add(new ToolbarItem("Insert", "addIcon.png",
                () => { }, ToolbarItemOrder.Primary));
            var deleteItem = new ToolbarItem("Remove", "removeIcon.png",
                () => { }, ToolbarItemOrder.Secondary);
            ToolbarItems.Add(deleteItem);
        }
    }
}