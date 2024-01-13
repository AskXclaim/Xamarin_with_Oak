using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginApp
{
    public partial class loginApp : ContentPage
    {
        public loginApp()
        {
            InitializeComponent();
        }

        private void LoginApp_OnLayoutChanged(object sender, EventArgs e)
        {
            var loginPage = (ContentPage)sender;
            if (loginPage.Width * loginPage.Height < 0) return;
            
            if (loginPage.Width > loginPage.Height)
            {
                loginGrid.ColumnDefinitions[1].Width = new GridLength(1, GridUnitType.Star);
                loginGrid.RowDefinitions[1].Height = 0;
                Grid.SetColumn(footerSection,1);
                Grid.SetRow(footerSection,0);
                welcome.VerticalOptions = LayoutOptions.StartAndExpand;
                welcomeUnderLine.VerticalOptions = LayoutOptions.StartAndExpand;

            }
            else
            {
                welcome.VerticalOptions = LayoutOptions.EndAndExpand;
                welcomeUnderLine.VerticalOptions = LayoutOptions.EndAndExpand;

                loginGrid.ColumnDefinitions[1].Width = 0;
                loginGrid.RowDefinitions[1].Height =new GridLength(1, GridUnitType.Star);
                Grid.SetColumn(footerSection,0);
                Grid.SetRow(footerSection,1);
                
            }
        }
    }
}