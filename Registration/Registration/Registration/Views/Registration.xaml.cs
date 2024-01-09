using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Registration.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registration : ContentPage
    {
        public Registration()
        {
            InitializeComponent();
            age.MinimumDate = DateTime.Now.AddYears(-80);
            age.MaximumDate = DateTime.Now;
            age.Date = DateTime.Today;
        }

        private async Task TapGestureRecognizer_OnTapped(object sender, EventArgs e)
        {
            
        }
    }
}