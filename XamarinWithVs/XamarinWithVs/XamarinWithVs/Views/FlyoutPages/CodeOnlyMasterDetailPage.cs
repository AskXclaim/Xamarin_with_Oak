using System;
using System.Collections.Generic;
using Xamarin.Forms;
using XamarinWithVs.Views.NavigationPages;

namespace XamarinWithVs.Views.MasterDetailPages
{
    [Obsolete]
    public class CodeOnlyMasterDetailPage : MasterDetailPage
    {
        public ListView ListView { get; set; } = new ListView();
        public CodeOnlyMasterDetailPage()
        {
            PopulateListView();
            Master = new ContentPage()
            {
                Title = "Lyseis Ltd",
                Content =new StackLayout()
                {
                    Children =
                    {
                        Shared.SharedLabel.GetCenteredLabel("Lyseis Ltd"),
                        ListView
                    }
                }

            };
            Detail = new NavigationPage(new CodeOnlyNavigationPage());
        }

        private void PopulateListView()
        {
            ListView.ItemsSource = new List<string>()
            {
                "Home","Services","Contact Us"
            };
        }
    }
}


