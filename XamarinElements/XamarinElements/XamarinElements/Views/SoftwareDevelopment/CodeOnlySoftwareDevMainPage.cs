using Xamarin.Forms;
using XamarinElements.Shared;

namespace XamarinElements.Views.SoftwareDevelopment
{
    public class CodeOnlySoftwareDevMainPage : TabbedPage
    {
        public CodeOnlySoftwareDevMainPage()
        {
            SetBarProperties();

            //<a target="_blank" href="https://icons8.com/icon/hoTHKdMkcrFk/home">Home</a> icon by <a target="_blank" href="https://icons8.com">Icons8</a>
            AddChildren(GetWelcomeStackLayout(Navigation));

        }

        private void SetBarProperties()
        {
            BarBackgroundColor = Color.FromHex("#084C61");
            BarTextColor = Color.White;
            SelectedTabColor = Color.FromHex("#357082");
        }

        private void AddChildren(StackLayout welcomeContent)
        {
            Children.Add(Elements.GetContentPage("Welcome", "softwareDev_home_icon.png", welcomeContent));
            Children.Add(new XamlCsharpPage());
        }
        private static StackLayout GetWelcomeStackLayout(INavigation navigation)
        {
            var welcomeStackLayout = Elements.GetStackLayout(new StackLayoutCall(padding: new Thickness(5, 10, 5, 10)));
            welcomeStackLayout.Margin = new Thickness(0, 10, 0, 0);
            welcomeStackLayout.Children.Add(Elements.GetLabel(new LabelCall(
                     "Welcome to sotware development services",
                     welcomeStackLayout.BackgroundColor, Color.FromHex("#ffffff"), 15)));

            var backBtn = Elements.GetBackButton();
            backBtn.Clicked += (sender, e) =>
            {
                navigation.PopModalAsync();
            };

            welcomeStackLayout.Children.Add(backBtn);
            return welcomeStackLayout;
        }
    }
}


